using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    //Definiremos los mé todos comunes que servira para todos los repositorios
    public interface IGenericRepository<Entity, T> where Entity : class
    {
        //Cualquier clase o interfaz que implemente esta interfaz generica estara obligada a implementar estos 4 metodos
        int Add(Entity entity); 
        int Update(Entity entity);
        int Remove(T id);
        IEnumerable<Entity> GetAll();
    }
}
