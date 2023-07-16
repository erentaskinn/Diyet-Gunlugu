using DiyetGunlugu.MODEL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.DAL.Configurations
{
    public class EatingMealConfiguration:BaseConfiguration<EatingMeal>
    {
        public override void Configure(EntityTypeBuilder<EatingMeal> builder)
        {
            builder.HasOne(x=>x.UserInformation)
                   .WithMany(x=>x.EatingMeals)
                   .HasForeignKey(x=>x.UserInformationID)
                   .HasPrincipalKey(x=>x.ID);
            builder.HasOne(x => x.Serving)
                  .WithMany(x => x.EatingMeals)
                  .HasForeignKey(x => x.ServingID)
                  .HasPrincipalKey(x => x.ID);

            builder.Property(x=>x.UserInformationID).IsRequired();
            builder.Property(x=>x.ServingID).IsRequired();
            builder.Property(x => x.Piece).HasDefaultValue(1);
            base.Configure(builder);
        }
    }
}
