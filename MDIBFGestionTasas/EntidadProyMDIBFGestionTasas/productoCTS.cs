using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadProyMDIBFGestionTasasDP
{
    public class productoCTS
    {
        private int _productoCTSId;
        private string _codigo;
        private string _nombre;
        private string _tasa;
        private string _moneda;
        private string _descripcion;
        private string _tipo;
        private string _tasasinpor;
        private string _clase;

        public int productoCTSId
        {
            get { return _productoCTSId; }
            set { _productoCTSId = value; }
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
        public string tasa
        {
            get { return _tasa; }
            set { _tasa = value; }
        }
        public string moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }
        public string descripcion        
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string tasasinpor
        {
            get { return _tasasinpor; }
            set { _tasasinpor = value; }
        }
        public string clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
    }
}
