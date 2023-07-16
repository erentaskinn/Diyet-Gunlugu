using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.ReportVM
{
    public class Reportview
    {
        public int UserinfoID { get; set; }
        public string NameSurname { get; set; }
        public DateTime EatingMealTime { get; set; }
        public float KALORI { get; set; }
        public int ORTALAMA { get; set; }
    }
}
