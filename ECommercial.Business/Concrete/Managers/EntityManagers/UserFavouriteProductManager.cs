using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserFavouriteProductManager : EntityServiceBase<UserFavouriteProduct>,IUserFavouriteProductService
    {
        private IUserFavouriteProductDal _UserFavouriteProductDal;
        public UserFavouriteProductManager(IUserFavouriteProductDal UserFavouriteProductDal,MemberInfo EntityPrimaryKeyMember):base(UserFavouriteProductDal,EntityPrimaryKeyMember)
        {
            _UserFavouriteProductDal = UserFavouriteProductDal;
        }
    }
}