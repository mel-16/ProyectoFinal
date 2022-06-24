using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    internal class HeladeriaBLL
    {
        internal object heladeria;

        public int NumeroID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Refrencia1 { get; set; }
        public string Referencia2 { get; set; }
        public Byte[] Fotodelsabor { get; set; }

        internal string HeladeriasBLL()
        {
            throw new NotImplementedException();
        }
    }
}
