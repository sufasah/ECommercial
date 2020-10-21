using System.Reflection;
using ECommercial.Business.Abstract.AbstractEntities;
using ECommercial.Core.Business;
using ECommercial.DataAccess.Abstract.AbstractEntities;
using ECommercial.Entites.concrete;
using FluentValidation;
using System.Collections.Generic;
namespace ECommercial.Business.Concrete.Managers.EntityManagers
{
    public class BrandManager : EntityServiceBase<Brand>,IBrandService
    {
        private IBrandDal _brandDal;
        public BrandManager(IBrandDal BrandDal,MemberInfo EntityPrimaryKeyMember):base(BrandDal,EntityPrimaryKeyMember)
        {
            _brandDal = BrandDal;
        }
        public override Brand Add(Brand Entity)
        {
            return base.Add(Entity);
        }

        public override void Delete(Brand Entity)
        {
            base.Delete(Entity);
        }

        public override List<Brand> GetAll()
        {
            return base.GetAll();
        }

        public override Brand Update(Brand Entity)
        {
            return base.Update(Entity);
        }
    }
}