using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Movil { get; set; }
        public string LinkedIn { get; set; }
        public string Vacante { get; set; }
        public string Notas { get; set; }
    }
}
