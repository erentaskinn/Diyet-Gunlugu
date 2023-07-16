using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.RepositoryInterface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        T Update(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Remove(int id);
    }
}
