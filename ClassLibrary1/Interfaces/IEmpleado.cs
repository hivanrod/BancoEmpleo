using ClassLibraryBancoEmpleo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Interfaces
{
    public interface IEmpleado
    {
        Task<Empleado> GetEmpleado(int id);  // Da un empleado segun el id
        Task<Empleado[]> GetEmpleados();  // Obtiene todos los empleados
        Task<Empleado> AdicionaEmpleado(Empleado empleado); // agrega un empleado
        Task<Empleado> AdicionaCargoxEmpleado(Empleado empleado, Cargo[] cargos); // agrega un o unos cargos a un empleado


    }
}
