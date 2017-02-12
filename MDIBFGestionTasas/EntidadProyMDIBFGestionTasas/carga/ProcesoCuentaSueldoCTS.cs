using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasas
{
    public class ProcesoCuentaSueldoCTS
    {
        private string _numerodocumento;
        private int _flag;
        private string _fechaaperturaCS;
        public string numerodocumento
        {
            get { return _numerodocumento; }
            set { _numerodocumento = value; }
        }
        public int flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        public string fechaaperturaCS
        {
            get { return _fechaaperturaCS; }
            set { _fechaaperturaCS = value; }
        }
    }
}
