using DiyetGunlugu.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class UserInformation:BaseEntity
    {
       
        public string NameSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public byte TargetWeight { get; set; }
        public byte Height { get; set; }
        public ActivityLevel? ActivityLevel { get; set; }


        //navprop
        public virtual ICollection<EatingMeal> EatingMeals { get; set; }
        public int UserID{ get; set; }
        public virtual ICollection<WeightChange> WeightChanges { get; set; }
        public virtual User User { get; set; }
    }
}
