using Ninject;
using Ninject.Modules;

namespace ECommercial.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        private static StandardKernel _kernel;
        public static StandardKernel StandardKernelInstance(){
            _kernel=_kernel??new StandardKernel();
            return _kernel;
        }
        public static T GetInstance<T>(NinjectModule module){
            var kernel = StandardKernelInstance();
            kernel.Load(module);
            return kernel.Get<T>();
        }
    }
}