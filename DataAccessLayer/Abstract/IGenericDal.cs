using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        List<T> GetListAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}
