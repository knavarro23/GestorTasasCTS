using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasas
{
    public class ProcesoMigracionCTS
    {
        public string _cuenta;
        private string _fechacambio;
        private int _codprodamigrar;
        private string _productoamigrar;
        public string cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }
        public string fechacambio
        {
            get { return _fechacambio; }
            set { _fechacambio = value; }
        }
        public int codprodamigrar
        {
            get { return _codprodamigrar; }
            set { _codprodamigrar = value; }
        }
        public string productoamigrar
        {
            get { return _productoamigrar; }
            set { _productoamigrar = value; }
        }
    }
}
