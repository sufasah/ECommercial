using System.Reflection;
using ECommercial.Business.Abstract;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract;
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