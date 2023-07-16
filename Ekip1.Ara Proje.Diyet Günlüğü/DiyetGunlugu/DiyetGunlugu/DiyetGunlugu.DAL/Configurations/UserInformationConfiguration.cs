using DiyetGunlugu.MODEL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.DAL.Configurations
{
    public class UserInformationConfiguration:BaseConfiguration<UserInformation>
    {
        public override void Configure(EntityTypeBuilder<UserInformation> builder)
        {
            builder
        .HasOne(u => u.User)
        .WithMany(ui => ui.UserInformation)
        .HasForeignKey(u => u.UserID);
            builder.Property(x => x.NameSurname).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.TargetWeight).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x=>x.ActivityLevel).IsRequired();
            base.Configure(builder);
        }
    }
}
