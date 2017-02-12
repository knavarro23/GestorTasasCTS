using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class proceso
    {
        private int _procesoId;
        private int _responsableId;
        private DateTime _fechaproceso;
        private string _nombrearchivo;
        private string _tipo;

        public int procesoId
        {
            get { return _procesoId; }
            set { _procesoId = value; }
        }

        public int responsableId
        {
            get { return _responsableId; }
            set { _responsableId = value; }
        }

        public DateTime fechaproceso
        {
            get { return _fechaproceso; }
            set { _fechaproceso = value; }
        }
        public string nombrearchivo
        {
            get { return _nombrearchivo; }
            set { _nombrearchivo = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}
