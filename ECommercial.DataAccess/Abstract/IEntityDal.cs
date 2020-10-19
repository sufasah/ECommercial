using System.Reflection;
namespace ECommercial.DataAccess.Abstract
{
    public interface IEntityDal
    {
        MemberInfo GetPrimaryKeyMember();
    }
}