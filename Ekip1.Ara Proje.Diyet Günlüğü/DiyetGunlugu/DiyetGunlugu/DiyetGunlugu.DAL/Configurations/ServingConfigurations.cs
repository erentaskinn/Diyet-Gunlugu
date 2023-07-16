using DiyetGunlugu.MODEL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.DAL.Configurations
{
    public class ServingConfigurations : BaseConfiguration<Servings>
    {
        public override void Configure(EntityTypeBuilder<Servings> builder)
        {
            builder.Property(x=>x.ServingGrams).IsRequired();
            builder.Property(x=>x.MeasurementType).IsRequired();
            builder.HasOne(x => x.Food)
                 .WithMany(x => x.Servings)
                 .HasForeignKey(x => x.FoodID)
                 .HasPrincipalKey(x => x.ID);
            base.Configure(builder);
        }
    }
}
