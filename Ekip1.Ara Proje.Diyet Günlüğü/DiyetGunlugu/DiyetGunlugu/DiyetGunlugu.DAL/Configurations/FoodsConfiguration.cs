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
    public class FoodsConfiguration:BaseConfiguration<Foods>
    {
        public override void Configure(EntityTypeBuilder<Foods> builder)
        {
            builder.HasOne(x => x.TypeOfFood)
                  .WithMany(x => x.Foods)
                  .HasForeignKey(x => x.TypeOfFoodsID)
                  .HasPrincipalKey(x => x.ID);
            
            base.Configure(builder);
        }
    }
}
