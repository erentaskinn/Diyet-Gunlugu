using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.ReportVM
{
    public class ReportViewsCategories
    {
        public int UserinfoID { get; set; }
        public string TypeOfFood { get; set; }
        public double Protein { get; set; }
        public double Yağ { get; set; }
        public double Karbonhidrat { get; set; }
        public string NameSurname { get; set; }
        public DateTime EatingMealTime { get; set; }
        public double KALORI { get; set; }
        public int Ortalama { get; set; }
    }
}
