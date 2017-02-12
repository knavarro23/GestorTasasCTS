using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class tipoproductoCTS
    {
        private string _codigo;
        private string _nombre;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
