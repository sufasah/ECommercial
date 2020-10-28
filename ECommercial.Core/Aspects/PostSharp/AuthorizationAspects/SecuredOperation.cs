using System.Security;
using System;
using PostSharp.Aspects;
namespace ECommercial.Core.Aspects.PostSharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation:OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles= Roles.Split(",");
            bool isAuthorized=false;
            foreach(var role in roles){
                if(!System.Threading.Thread.CurrentPrincipal.IsInRole(role)){
                    isAuthorized=true;
                    break;
                }
            }
            if(!isAuthorized){
                throw new SecurityException("User is not authorized who trying to access the method");
            }
            
        }
    }
}