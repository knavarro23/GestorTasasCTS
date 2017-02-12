using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class usuario
    {
        private int _usuarioId;
        private string _nombre1;
        private string _nombre2;
        private string _apellido1;
        private string _apellido2;
        private string _username;
        private string _password;
        private int _activo;

        public int usuarioId
        {
            get { return _usuarioId; }
            set { _usuarioId = value; }
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

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
    }
}
