using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class responsable
    {
        private int _responsableId;
        private string _nombre1;
        private string _nombre2;
        private string _apellido1;
        private string _apellido2;
        private string _nombrecompleto;
        private int _activo;

        public int responsableId
        {
            get { return _responsableId; }
            set { _responsableId = value; }
        }

        public string nombre1
        {
            get { return _nombre1; }
            set { _nombre1 = value; }
        }

        public string nombre2
        {
            get { return _nombre2; }
            set { _nombre2 = value; }
        }

        public string apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }

        public string apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }

        public string nombrecompleto
        {
            get { return _nombrecompleto; }
            set { _nombrecompleto = value; }
        }
        public int activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
    }
}
