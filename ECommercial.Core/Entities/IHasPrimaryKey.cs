using System;
namespace ECommercial.Core.Entities
{
    public interface IHasPrimaryKey<TKey>
        where TKey: IEquatable<Object>
    {
        TKey GetId();
    }
}