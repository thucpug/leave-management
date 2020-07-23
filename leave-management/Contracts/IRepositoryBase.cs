using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    interface IRepositoryBase<T> where T : class
    {
        ICollection<T> findAll();
        T findById(int id);
        bool Update(T entity);
        bool Create(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
