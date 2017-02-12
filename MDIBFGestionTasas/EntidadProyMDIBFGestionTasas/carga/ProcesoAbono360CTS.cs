using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasas
{
    public class ProcesoAbono360CTS
    {
        public string _numerocuenta;
        private string _fecha;
        private int _flag;

        public string numerocuenta
        {
            get { return _numerocuenta; }
            set { _numerocuenta = value; }
        }
        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public int flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
    }
}
