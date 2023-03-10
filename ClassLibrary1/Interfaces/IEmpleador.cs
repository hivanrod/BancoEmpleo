using ClassLibraryBancoEmpleo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Interfaces
{
    public interface IEmpleador
    {
        Task<Empleador> GetEmpleador(int id);  // Da un empleador segun el id
        Task<Empleador[]> GetEmpleadores();  // Obtiene todos los empleadores
        Task<Empleador> AdicionaEmpleador(Empleador empleador); // agrega un empleador
        Task<Empleador> AdicionaCargoxEmpleador(Empleador empleador, Cargo[] cargos); // agrega un o unos cargos vacantes a un empleador
    }
}
