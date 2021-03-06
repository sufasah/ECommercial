
using ECommercial.Entities.concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommercial.DataAccess.EntitiyFramework.Mappings
{
    public class AddressMap:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
        
            builder.ToTable(@"addresses",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int?>();
            
            builder.Property(x=>x.address).HasColumnName("address");
            
            builder.Property(x=>x.CityId).HasColumnName("city_id");
            
            builder.Property(x=>x.ReceiverName).HasColumnName("receiver_name");
            
            builder.Property(x=>x.ReceiverNumber).HasColumnName("receiver_number");
            
            builder.Property(x=>x.ReceiverSurname).HasColumnName("receiver_surname");
            
            builder.Property(x=>x.UserShopId).HasColumnName("user_shop_id");
            
        }
    }
}