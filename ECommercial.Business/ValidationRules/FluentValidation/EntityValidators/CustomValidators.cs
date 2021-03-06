using System;
using FluentValidation;

namespace ECommercial.Business.ValidationRules.FluentValidation.EntityValidators
{
    public static class CustomValidators
    {
        public static IRuleBuilderOptions<T,int?> PrimaryKeyIdRule<T>(this IRuleBuilder<T,int?> ruleBuilder){
            return ruleBuilder
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
        public static IRuleBuilderOptions<T,long?> PrimaryKeyIdRule<T>(this IRuleBuilder<T,long?> ruleBuilder){
            return ruleBuilder
                .NotNull()
                .GreaterThanOrEqualTo(0);
        }
        public static IRuleBuilderOptions<T,long?> PhoneNumberRule<T>(this IRuleBuilder<T,long?> ruleBuilder){
            return ruleBuilder
                .GreaterThan(05000000000)
                .LessThan(06000000000);
        }
        public static IRuleBuilderOptions<T,Enum> EnumValueMaximumLength<T>(this IRuleBuilder<T,Enum> ruleBuilder,int length){
            return ruleBuilder.Must(t=>t.ToString().Length<=length);
        }

    }
}