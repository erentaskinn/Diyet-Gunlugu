using DiyetGunlugu.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class EatingMeal:BaseEntity
    {
        public DateTime EatingMealTime { get; set; }
        public Mealstime MealTime { get; set; }
        //navprop

        public int ServingID { get; set; }
        public int Piece { get; set; }
        public int UserInformationID { get; set; }
        public virtual Servings Serving { get; set; }
        public virtual UserInformation UserInformation { get; set; }

    }
}
