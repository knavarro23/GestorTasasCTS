using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class ProcesoCuentaSueldoDP
    {
        private string _llave;
        private string _fechaaperturaCS;
        public string llave
        {
            get { return _llave; }
            set { _llave = value; }
        }
        public string fechaaperturaCS
        {
            get { return _fechaaperturaCS; }
            set { _fechaaperturaCS = value; }
        }
    }
}
