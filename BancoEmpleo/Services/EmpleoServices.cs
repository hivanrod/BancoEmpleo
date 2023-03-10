using ClassLibraryBancoEmpleo.Interfaces;
using ClassLibraryBancoEmpleo.Models;

namespace BancoEmpleo.Services
{
    public class EmpleoServices : IEmpleo
    {

        public Task<Empleo[]> AdicionaEmpleosxEmpleado(Empleado empleado, Empleo empleo, Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo[]> AdicionaEmpleosxEmpleador(Empleador empleador, Empleo empleo, Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo> AdicionaEmpleoxCargo(Empleo empleo, Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo> GetEmpleo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Empleo[]> GetEmpleosTodos()
        {
            Empleo[] result = new Empleo[0];
            return result;
        }

        public Task<Empleo[]> GetEmpleosxCargo(string buscar, Empleo empleo, Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo[]> GetEmpleosxEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo[]> GetEmpleosxEmpleador(Empleador empleador, Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo[]> GetEmpleosxZona(string buscar, Empleado empleado, Cargo cargo, Zona zona)
        {
            throw new NotImplementedException();
        }
    }
}
