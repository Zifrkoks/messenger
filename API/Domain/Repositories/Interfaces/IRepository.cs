using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain.Repositories.Interfaces
{
    public interface IRepository<T>
    where T: class
    {
        public bool Create(T obj);

        public T Read(int id);

        public bool Update(int id, T obj);

        public bool Delete(int id);
    }
}