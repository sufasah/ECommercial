using System;
using ECommercial.Business.ValidationRules.FluentValidation.EntityValidators;
using ECommercial.Core.CrossCuttingConcerns.Validaton.FluentValidation;
using ECommercial.Core.Entities;
using ECommercial.Entites.concrete;
using FluentValidation;
using Xunit;

namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation.EntitiyTests
{
    public class AddressFixture : IDisposable
    {

        public AddressValidator Validator;
        public AddressFixture()
        {
            Validator=(AddressValidator)EntityValidationFixture.Validators[0][0];
        }

        public void Dispose()
        {
            Assert.True(true);
        }
    }
    public class AddressTests:IClassFixture<AddressFixture>
    {
        private AddressFixture _fixture;
        public Address AddressEntity;

        public AddressTests(AddressFixture fixture)
        {
            _fixture = fixture;
            AddressEntity=new Address(
            (short)EntityValidationFixture.idExample,
            (short)EntityValidationFixture.idExample,
            EntityValidationFixture.phoneExample,
            (short)EntityValidationFixture.idExample,
            EntityValidationFixture.addressExample,
            EntityValidationFixture.nameExample,
            EntityValidationFixture.surnameExample
            );
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(null)]
        public void throws_exception_id_primarykey(long value){
            AddressEntity.Id=(int)value;
            Assert.Throws<ValidationException>(()=>{
                FluentValidationTool.Validate(_fixture.Validator,AddressEntity);
            });
        }

        
    }
}