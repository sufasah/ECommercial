using System.Reflection;
namespace ECommercial.DataAccess.Abstract.AbstractEntities
{
    public interface IEntityDal
    {
        MemberInfo GetPrimaryKeyMember();
    }
}