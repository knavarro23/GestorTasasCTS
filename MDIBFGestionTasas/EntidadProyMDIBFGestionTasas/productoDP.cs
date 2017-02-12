using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class productoDP
    {
        private int _productoId;
        private string _codigo;
        private string _nombre;
        private string _tipo;
        public int productoId
        {
            get { return _productoId; }
            set { _productoId = value; }
        }
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
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}
