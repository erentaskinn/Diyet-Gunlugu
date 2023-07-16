using DiyetGunlugu.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.MODEL.Entity
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUserID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserID { get; set; }
        public Status? Status { get; set; }
        public int? DeletedUserID { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
