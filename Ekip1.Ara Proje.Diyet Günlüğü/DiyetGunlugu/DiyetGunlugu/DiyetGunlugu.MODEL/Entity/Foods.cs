using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class Foods:BaseEntity
    {
        public string FoodName { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float Carbohydrate { get; set; }
        public byte[] FoofPicture { get; set; }
        //navprop
        public int TypeOfFoodsID { get; set; }
        public virtual TypeOfFoods TypeOfFood { get; set; }
        public virtual ICollection<Servings> Servings { get; set; }
    }
}
