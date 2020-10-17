using System.ComponentModel;
using System.Reflection.Emit;
using System.Xml.Linq;
using System;
using ECommercial.Entites.concrete;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommercial.Core.DataAccess.EntitiyFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"products",@"public");
            
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Id).HasColumnName("id").UseIdentityAlwaysColumn<int>();

            builder.Property(x=>x.Expiry).HasColumnName("expiry");
            
            builder.Property(x=>x.Name).HasColumnName("name");
            
            builder.Property(x=>x.Properties).HasColumnName("properties");
            
            builder.Property(x=>x.SubsubcategoryId).HasColumnName("subsubcategory_id");
            
            builder.Property(x=>x.VatRate).HasColumnName("vat_rate");
            
            builder.Property(x=>x.WarrantyPeriod).HasColumnName("warranty_period");
            
            builder.Property(x=>x.WarrantyType).HasColumnName("warranty_type").HasConversion(new EnumToStringConverter<Product.WarrantyTypes>());

            builder.Property(x=>x.Barcode).HasColumnName("barcode");
            
            builder.Property(x=>x.BrandId).HasColumnName("brand_id");
            
            builder.Property(x=>x.CargoCorporation).HasColumnName("cargo_corporation");
            
            builder.Property(x=>x.Commission).HasColumnName("commission");
            
            builder.Property(x=>x.Deci).HasColumnName("deci");

            builder.Property(x=>x.Description).HasColumnName("description");
            
            
        }
    }
}