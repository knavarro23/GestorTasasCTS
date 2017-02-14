using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class productoCTS
    {
        DatosProyMDIBFGestionTasasDP.productoCTS mproductoCTS = new DatosProyMDIBFGestionTasasDP.productoCTS();
        public DataTable ListarProductoCTS(string CadenaConexion, string tipoproducto)
        {
            return mproductoCTS.ListarProductoCTS(CadenaConexion, tipoproducto);
        }

        public DataTable BuscarProductoCTS(string CadenaConexion, string strtipoproducto, string strcodigo, string strnombres)
        {
            return mproductoCTS.BuscarProductoCTS(CadenaConexion, strtipoproducto, strcodigo, strnombres);
        }
        public DataTable SeleccionarUnoPoductoCTS(string CadenaConexion, int productoCTSId)
        {
            return mproductoCTS.SeleccionarUnoProductoCTS(CadenaConexion, productoCTSId);
        }
        public bool InsertarProductoCTS(string CadenaConexion, EntidadProyMDIBFGestionTasas.productoCTS Entidad)
        {
            return mproductoCTS.InsertarProductoCTS(CadenaConexion, Entidad);
        }
        public bool ActualizarProductoCTS(string CadenaConexion, EntidadProyMDIBFGestionTasas.productoCTS Entidad)
        {
            return mproductoCTS.ActualizarProductoCTS(CadenaConexion, Entidad);
        }
    }
}
