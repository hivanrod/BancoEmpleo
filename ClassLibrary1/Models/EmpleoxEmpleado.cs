using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Models
{
    public class EmpleoxEmpleado
    {
        public int IdEmpleo { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public string Notas { get; set; }
    }
}
