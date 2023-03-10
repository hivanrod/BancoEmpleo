using ClassLibraryBancoEmpleo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Interfaces
{
    public interface IEmpleo
    {
        Task<Empleo> GetEmpleo(int id); // Solo un empleo
        Task<Empleo[]> GetEmpleosTodos(); // Todos los empleos
        Task<Empleo[]> GetEmpleosxEmpleador(Empleador empleador, Cargo cargo); // Todos los empleos posibles creados por un empleador
        Task<Empleo[]> AdicionaEmpleosxEmpleador(Empleador empleador, Empleo empleo, Cargo cargo); // Adiciona vacantes de empleo para un cargo creados por un empleador
        Task<Empleo[]> AdicionaEmpleosxEmpleado(Empleado empleado, Empleo empleo, Cargo cargo); // Adiciona vacantes de empleo para un cargo creados por un empleado
        Task<Empleo[]> GetEmpleosxEmpleado(Empleado empleado); // Todos los empleos posibles para un empleado
        Task<Empleo[]> GetEmpleosxCargo(string buscar, Empleo empleo, Cargo cargo); // filtra empleos por cargo o palabra clave
        Task<Empleo> AdicionaEmpleoxCargo(Empleo empleo, Cargo cargo); // adiciona empleos por cargo 
        Task<Empleo[]> GetEmpleosxZona(string buscar, Empleado empleado, Cargo cargo, Zona zona); // filtra empleos por Zona y empleado o palabra clave

    }
    public class InfoEmpleo : IEmpleo
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

        public async Task<Empleo> GetEmpleo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empleo[]> GetEmpleosTodos()
        {
            throw new NotImplementedException();
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
