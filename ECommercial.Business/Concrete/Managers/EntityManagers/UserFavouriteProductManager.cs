using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserFavouriteProductManager : EntityServiceBase<UserFavouriteProduct>,IUserFavouriteProductService
    {
        private IUserFavouriteProductDal _userFavouriteProductDal;
        private IEntityDal<UserFavouriteProduct> _entityDal;
        public UserFavouriteProductManager(IUserFavouriteProductDal userFavouriteProductDal,IEntityDal<UserFavouriteProduct> entityDal):base(userFavouriteProductDal,entityDal.GetPrimaryKeyMember())
        {
            _userFavouriteProductDal = userFavouriteProductDal;
            _entityDal=entityDal;
        }
        public override UserFavouriteProduct Add(UserFavouriteProduct Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(UserFavouriteProduct Entity)
        {
            base.Delete(Entity);
        }

        public override List<UserFavouriteProduct> GetAll()
        {
            return base.GetAll();
        }

        public override UserFavouriteProduct Update(UserFavouriteProduct Entity)
        {
            return base.Update(Entity);
        }
    }
}