using DiyetGunlugu.MODEL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.DAL.Configurations
{
    public class WeightChangesConfiguration : BaseConfiguration<WeightChange>
    {
        public override void Configure(EntityTypeBuilder<WeightChange> builder)
        {
            builder.HasOne(x => x.UserInformation)
                   .WithMany(x => x.WeightChanges)
                   .HasForeignKey(x => x.UserInformationID);
            builder.Property(x => x.weight)
                   .IsRequired();
            builder.Property(x => x.Time)
                   .IsRequired();
            base.Configure(builder);
        }
    }
}
