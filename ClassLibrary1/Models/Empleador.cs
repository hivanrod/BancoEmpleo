using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Models
{
    public class Empleador
    {
        public int Id { get; set; }
        public string NIT { get; set; }
        public string Descripción { get; set; }
        public string CorrerElectronico { get; set; }
        public string LinkedIn { get; set; }
        public string Movil { get; set; }
        public string Notas { get; set; }

    }
}
