using System.Reflection;
using System;
using System.Linq;
using ECommercial.Core.CrossCuttingConcerns.Validaton.FluentValidation;
using ECommercial.Core.Entities;
using ECommercial.Entites.concrete;
using FluentValidation;
using Xunit;
using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;

[assembly:CollectionBehavior(DisableTestParallelization=true)]
namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation
{
    [TestCaseOrderer("ECommercial.Business.Tests.EntityValidationTests.FluentValidation.PriorityOrderer","ECommercial.Business.Tests")]
    public class EntityValidationTests:IClassFixture<EntityValidationFixture>
    {
        
        private EntityValidationFixture _fixture;

        public EntityValidationTests(EntityValidationFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory,TestPriority(1)]
        [MemberData(nameof(EntityValidationFixture.EntityValidator),MemberType=typeof(EntityValidationFixture))]
        public void validateSuccess(IValidator validator,IEntity entity){
            FluentValidationTool.Validate(validator,entity);
        }
        
        [Theory,TestPriority(2)]
        [InlineData(typeof(Product),typeof(ProductValidator),"Id",null)]
        public void validationFail(Type entityType,Type validatorType,string memberName,Object propertyValue){
            IEntity entity =(IEntity)EntityValidationFixture.Entities.Where(t=>t[0].GetType()==entityType).First()[0];
            IValidator validator = (IValidator)EntityValidationFixture.Validators.Where(t=>t[0].GetType()==validatorType).First()[0];
            var member = entity.GetType().GetMember(memberName)[0];
            if(member.MemberType==MemberTypes.Property){
                var propretyTested=(PropertyInfo)member;
                propretyTested.SetValue(entity,propertyValue);
            }
            else if(member.MemberType==MemberTypes.Field){
                var fieldTested=(FieldInfo)member;
                fieldTested.SetValue(entity,propertyValue);
            }
            else
                throw new Exception("member is not an property or field");

            Assert.Throws<ValidationException>(()=>{
                FluentValidationTool.Validate(validator,entity);
            });
        }
    }
}
