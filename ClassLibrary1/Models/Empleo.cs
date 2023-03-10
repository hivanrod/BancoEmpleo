using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Models
{
    public class Empleo
    {
        public int Id { get; set; }
        public int IdEmpleador { get; set; }
        public int IdCargoTipo { get; set; }
        public string Descripcion { get; set; }
        public string Requisitos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Ubicacion { get; set; }
        public decimal Salario { get; set; }
        public bool Diario { get; set; }
        public bool Jornal { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaHoraActiva { get; set; }
        public DateTime FechaHoraInactiva { get; set; }
    }
}
