using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class Servings:BaseEntity
    {
        public int ServingGrams { get; set; }
        public int MeasurementType { get; set; }
        //nav prop  
        public virtual ICollection<EatingMeal> EatingMeals { get; set; }
        public int FoodID { get; set; }
        public virtual Foods Food { get; set; }
    }
}
