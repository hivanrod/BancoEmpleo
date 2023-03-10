using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Models
{
    public class CargoTipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal SalarioPromedio { get; set; }
        public bool DiarioPromedio { get; set; }
        public bool JornalPromedio { get; set; }
        public int IdZona { get; set; }
        public int IdCargo { get; set; }
        public string Notas { get; set; }
    }
}
