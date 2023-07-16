using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class TypeOfFoods:BaseEntity
    {
        public string TypeOfFood { get; set; }
        //navprop
        public virtual ICollection<Foods> Foods { get; set; }
    }
}
