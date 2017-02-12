using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasas
{
    public class ProcesoContactoCTS
    {
        private string _cuenta;
        private string _llave;
        private string _correoelectronico;
        private string _telefonocelular;
        private string _telefonofijo;
        private string _direccion;

        public string cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }
        public string llave
        {
            get { return _llave; }
            set { _llave = value; }
        }
        public string correoelectronico
        {
            get { return _correoelectronico; }
            set { _correoelectronico = value; }
        }
        public string telefonocelular
        {
            get { return _telefonocelular; }
            set { _telefonocelular = value; }
        }
        public string telefonofijo
        {
            get { return _telefonofijo; }
            set { _telefonofijo = value; }
        }
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
    }
}
