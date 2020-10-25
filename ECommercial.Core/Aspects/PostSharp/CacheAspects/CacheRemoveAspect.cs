using System;
using System.Linq;
using System.Reflection;
using ECommercial.Core.CorssCuttingConcerns.Caching;
using PostSharp.Aspects;
namespace ECommercial.Core.Aspects.PostSharp.CacheAspects
{
    public class CacheRemoveAspect:OnMethodBoundaryAspect
    {
        private Type _cacheType;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if(typeof(ICacheManager).IsAssignableFrom(_cacheType)==false){
                throw new Exception("Wrong Cache Manager");
            }
            _cacheManager=(ICacheManager)Activator.CreateInstance(_cacheType);

            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.remove // Pattern doesn't work because cache cant iterable using linq methods. An problem occured and will be solved.
            base.OnSuccess(args);
        }
    }
}