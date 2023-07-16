using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.RepositoryInterface
{
    public interface IReportViewRepostroy
    {
        public IEnumerable<object> FıllDgvDailyReport(int userInformationId, DateTime dateTime);
        public IEnumerable<object> FıllDgvWeekRepor(int UserinfoID,DateTime dateTime);
        public IEnumerable<object> ReportByFoodCategoryWeek(int UserinfoID, DateTime dateTime);
        public IEnumerable<object> ReportByFoodCategoryMounth(int UserinfoID, DateTime dateTime);
        public IEnumerable<object> FıllDgvMounthReport(int UserinfoID, DateTime dateTime);
        public IEnumerable<object> FıllDgvTheMostEatenFoodTypeOf();
        public IEnumerable<object> FıllTheMostEatenFood();



    }
}
