using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using CapaEntidades.Entities;

namespace CapaDatos.Contracts
{
    //Interfaz especifica para el repositorio de la entidad cliente.
    public interface IClienteRepository : IGenericRepository<Cliente, int> //El primer parametro es la clase de la interfaz, el segundo parametro es el tipo de dato de la clave primaria
    {
        Cliente findByDoc(string nroDoc);
        //Otros metodos
        //Si nuestras entidades solo necesitan los 4 métodos basicos entonces se puede implementar directamente el repositorio genérico.

        int getCount();

        List<Mascota> GetMascotas(int idCliente);
    }

}
