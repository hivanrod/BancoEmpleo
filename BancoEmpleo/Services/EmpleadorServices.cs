using ClassLibraryBancoEmpleo.Interfaces;
using ClassLibraryBancoEmpleo.Models;

namespace BancoEmpleo.Services

{
    public partial class EmpleadorServices : IEmpleador
    {
        public Task<Empleador> AdicionaCargoxEmpleador(Empleador empleador, Cargo[] cargos)
        {
            throw new NotImplementedException();
        }

        public Task<Empleador> AdicionaEmpleador(Empleador empleador)
        {
            throw new NotImplementedException();
        }

        public Task<Empleador> GetEmpleador(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empleador[]> GetEmpleadores()
        {
            throw new NotImplementedException();
        }
    }
}
