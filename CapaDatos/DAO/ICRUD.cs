using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DAO
{
    public interface ICRUD<T>
    {
        List<T> getAll();
        T getOne(int id);
        void update(T t);
        void delete(int id);
        void add(T t);
    }
}
