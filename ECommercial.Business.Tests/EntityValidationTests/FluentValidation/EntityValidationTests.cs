using ECommercial.Core.CrossCuttingConcerns.Validaton.FluentValidation;
using ECommercial.Core.Entities;
using FluentValidation;
using Xunit;

namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation
{
    public class EntityValidationTests:IClassFixture<EntityValidationFixture>
    {
        
        private EntityValidationFixture _fixture;

        public EntityValidationTests(EntityValidationFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [MemberData(nameof(EntityValidationFixture.EntityValidator),MemberType=typeof(EntityValidationFixture))]
        public void validateShouldSuccess(IValidator validator,IEntity entity){
            FluentValidationTool.Validate(validator,entity);
            Assert.True(true);
        }
        [Fact]
        public void Is_Null(){

        }
    }
}
