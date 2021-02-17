using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entities.concrete;
using AutoMapper;
using System.Collections.Generic;

namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class UserFavouriteProductManager : EntityServiceBase<UserFavouriteProduct>,IUserFavouriteProductService
    {
        private readonly IUserFavouriteProductDal _userFavouriteProductDal;
        private readonly IEntityDal<UserFavouriteProduct> _entityDal;
        private readonly IMapper _mapper;
        public UserFavouriteProductManager(IUserFavouriteProductDal userFavouriteProductDal,IEntityDal<UserFavouriteProduct> entityDal,IMapper mapper):base(userFavouriteProductDal,entityDal.GetPrimaryKeyMember(),mapper)
        {
            _userFavouriteProductDal = userFavouriteProductDal;
            _entityDal=entityDal;
            _mapper=mapper;
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