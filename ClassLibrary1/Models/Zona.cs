using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBancoEmpleo.Models
{
    public class Zona
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Indicaciones { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public double RadioCirculo { get; set; }
        public int CantidadCirculos { get; set; }
    }
}
