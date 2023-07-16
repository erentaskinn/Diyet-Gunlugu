using DiyetGunlugu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL
{
    public class DataBase_Diyet
    {
        private static DiyetGunlugu_DbContext dataBase;

        public static DiyetGunlugu_DbContext DataBase
        {
            get
            {
                if (dataBase == null)
                    dataBase = new DiyetGunlugu_DbContext();
                return dataBase;
            }

        }
    }
}
