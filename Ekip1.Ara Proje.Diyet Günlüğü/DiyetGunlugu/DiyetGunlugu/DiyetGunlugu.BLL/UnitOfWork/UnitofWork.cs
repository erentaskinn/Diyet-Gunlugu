using DiyetGunlugu.BLL.Repository;
using DiyetGunlugu.BLL.RepositoryInterface;
using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.UnitOfWork
{
    public class UnitofWork : BaseEntity
    {
        private static UnitofWork instance;



        public static UnitofWork Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitofWork();
                }
                return instance;
            }
        }
        public  IFoodsRepostory Foods
        {
            get
            {
                return new FoodsRepostroy();
            }
        }
        public  IServingRepostory Serving
        {
            get
            {
                return new ServingRepostory();
            }
        }
        public  IUserInformationRepository UserInformation
        {
            get
            {
                return new UserInformationRepository();
            }
        }

        public  IEatingMealRepository EatingMeal
        {
            get
            {
                return new EatingMealRepository();
            }
        }
        public IPasswordBusiness PasswordChangeBusiness
        {
            get
            {
                return new PasswordBusiness();
            }
        }
        public IUserRepository User
        {
            get
            {
                return new UserRepository();
            }
        }
        public IWeightChangeRepository WeightChangeRepository
        {
            get
            {
                return new WeightChangeRepository();
            }
        }
        public IReportViewRepostroy ReportViewRepostroy
        {
            get
            {
                return new ReportViewRepostroy();
            }
        }
        public ITypeOfFoodsRepostroy TypeOfFoodsRepostroy
        {
            get
            {
                return new TypeOfFoodRepostory();
            }
        }
    }
}
