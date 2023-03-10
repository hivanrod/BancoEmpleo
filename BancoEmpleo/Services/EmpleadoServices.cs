using ClassLibraryBancoEmpleo.Interfaces;
using ClassLibraryBancoEmpleo.Models;

namespace BancoEmpleo.Services
{
    public class EmpleadoServices : IEmpleado
    {
        public Task<Empleado> AdicionaCargoxEmpleado(Empleado empleado, Cargo[] cargos)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> AdicionaEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> GetEmpleado(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Empleado[]> GetEmpleados()
        {
            Empleado[] result = new Empleado[0];
            return result;
        }
    }
}
