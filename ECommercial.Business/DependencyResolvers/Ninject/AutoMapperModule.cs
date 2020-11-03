using AutoMapper;
using ECommercial.Core.Utilities.Mappings;
using Ninject.Modules;

namespace ECommercial.Business.DependencyResolvers.Ninject
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToConstant(AutoMapperHelper.CreateConfiguration().CreateMapper());
        }
        
    }
}