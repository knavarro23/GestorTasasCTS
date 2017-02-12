using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class ProcesoClienteCMRDP
    {
        private string _llave;
        private string _t_cliente;
        public string llave
        {
            get { return _llave; }
            set { _llave = value; }
        }
        public string t_cliente
        {
            get { return _t_cliente; }
            set { _t_cliente = value; }
        }
    }
}
