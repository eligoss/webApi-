using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T t);
        void Edit(T t);
        void Remove(string Id);
        IEnumerable<T> GetCity();
        T FindById(int Id);
    }
}
