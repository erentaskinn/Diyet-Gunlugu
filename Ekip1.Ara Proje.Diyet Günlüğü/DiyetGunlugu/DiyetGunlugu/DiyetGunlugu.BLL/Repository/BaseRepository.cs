using DiyetGunlugu.BLL.RepositoryInterface;
using DiyetGunlugu.DAL;
using DiyetGunlugu.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.BLL.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Data Base ekleme yapılırken kullanılan metot
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Add(T entity)
        {
            var entiry = DataBase_Diyet.DataBase.Set<T>().Add(entity);
            DataBase_Diyet.DataBase.SaveChanges();
            return entiry.Entity;
        }
        /// <summary>
        /// Data Base güncelleme yapılan metot
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Update(T entity)
        {
            var update = DataBase_Diyet.DataBase.Set<T>().Update(entity);
            DataBase_Diyet.DataBase.SaveChanges();
            return update.Entity;
        }
        /// <summary>
        /// Data baseden bütün verileri getirme metodu
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            var values = DataBase_Diyet.DataBase.Set<T>()
                .Where(x => x.Status !=MODEL.Enums.Status.Deleted).ToList();
            return values;
        }
        /// <summary>
        /// Data baseden ıd ye göre verileri getirme metodu
        /// </summary>
        /// <param name="id">parametreolarak ıd yollanıp filtreleme yapılır</param>
        /// <returns></returns>

        public T GetById(int id)
        {
            var values = DataBase_Diyet.DataBase.Set<T>().FirstOrDefault(x => x.ID == id);
            return values;
        }
        /// <summary>
        /// Data basade verileri silme metodu
        /// </summary>
        /// <param name="id">parametre olarak verilen ıd ile filtreleme yapılıp o ıd deki verileri bulma</param>
        public void Remove(int id)
        {
            var deletedValue = GetById(id);
            DataBase_Diyet.DataBase.Set<T>().Remove(deletedValue);
            DataBase_Diyet.DataBase.SaveChanges();
        }
    }
}