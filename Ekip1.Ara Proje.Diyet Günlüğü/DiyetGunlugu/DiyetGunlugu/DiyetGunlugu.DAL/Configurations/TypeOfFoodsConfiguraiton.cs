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
    public class TypeOfFoodsConfiguraiton:BaseConfiguration<TypeOfFoods>
    {
        public override void Configure(EntityTypeBuilder<TypeOfFoods> builder)
        {
            
            base.Configure(builder);
        }
    }
}
