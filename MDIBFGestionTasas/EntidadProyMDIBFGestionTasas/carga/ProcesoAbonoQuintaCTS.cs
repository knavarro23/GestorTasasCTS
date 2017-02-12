using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasas
{
    public class ProcesoAbonoQuintaCTS
    {
        private string _numerodocumento;
        private string _fecha;
        private int _flag;
        public string numerodocumento
        {
            get { return _numerodocumento; }
            set { _numerodocumento = value; }
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
