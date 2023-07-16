using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class WeightChange:BaseEntity
    {
        public int weight { get; set; }
        public DateTime Time { get; set; }

        //navprop
        public int UserInformationID { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
