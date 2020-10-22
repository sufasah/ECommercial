using ECommercial.Core.Entities;
using FluentValidation;

namespace ECommercial.Core.CrossCuttingConcerns.Validaton.FluentValidation
{
    public static class FluentValidationTool
    {
        public static void validate(IValidator validator,IEntity entity){
            var result =validator.Validate(new ValidationContext<IEntity>(entity));
            if(result.Errors.Count>0){
                throw new ValidationException(result.Errors);
            }
        }
    }
}