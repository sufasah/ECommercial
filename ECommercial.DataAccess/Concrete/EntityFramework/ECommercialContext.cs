using ECommercial.Entites.concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommercial.DataAccess.EntityFramework
{
    public class ECommercialContext:DbContext
    {
        public DbSet<Address> Addresses {get;set;}
    }
}