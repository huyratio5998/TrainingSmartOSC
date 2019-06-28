using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Repository.Interface
{
    interface IBaseRepository<T>
    {
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void SaveChange();
    }
}
