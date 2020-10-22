using ECommercial.Core.Entities;
using ECommercial.Core.CrossCuttingConcerns.Validaton;
using Xunit;
using ECommercial.Core.CrossCuttingConcerns.Validaton.FluentValidation;
using FluentValidation;
using System.Collections.Generic;
using System.Collections;

namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation
{
    public class EntityValidationTests:IClassFixture<EntityValidationFixture>
    {
        public EntityValidationTests()
        {

        }

        [Theory]
        [MemberData(nameof(Entities),parameters:1),MemberData(nameof(Validators))]
        public void validateShouldSuccess(IEntity entity,IValidator validator){
           FluentValidationTool.validate(validator,entity);
        }
        [Theory]
        public void Is_Null(){

        }
    }
}
