using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGnericDal<T> where T:class
    {
        // CRUD ISLEMLERI ICIN GENERIC INTERFACE
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
        List<T> GetByFiltre(Expression<Func<T, bool>> filtre);

    }
}
