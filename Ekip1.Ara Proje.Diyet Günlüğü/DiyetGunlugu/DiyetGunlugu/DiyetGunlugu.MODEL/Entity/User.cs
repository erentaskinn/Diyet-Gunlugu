using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class User:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool FirstLogin { get; set; }
        public string? ActivationCode { get; set; }
        //navprop
        public virtual ICollection< UserInformation> UserInformation { get; set; }
       

    }
}
