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
    public interface IClienteRepository:IGenericRepository<Cliente, string> //El primer parametro es la clase de la interfaz, el segundo parametro es el tipo de dato de la clave primaria
    {
        int Remove(string nroDoc, string tipoDoc);
        int Update(Cliente cliente, string nroDoc, string tipoDoc);
        //Otros metodos
        //Si nuestras entidades solo necesitan los 4 métodos basicos entonces se puede implementar directamente el repositorio genérico.
    }
}
