using System;
using System.Linq;
using ECommercial.Core.CrossCuttingConcerns.Validaton.FluentValidation;
using ECommercial.Core.Entities;
using FluentValidation;
using PostSharp.Aspects;
namespace ECommercial.Core.Aspects.PostSharp
{
    [Serializable]
    public class FluentValidationAspect:OnMethodBoundaryAspect
    {
        private Type _validatorType;

        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            IValidator validator = (IValidator)Activator.CreateInstance(_validatorType);
            Type entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t=>t.GetType()==entityType);
            
            foreach(var entity in entities){
                FluentValidationTool.validate(validator,(IEntity)entity);
            }
        }
    }
}