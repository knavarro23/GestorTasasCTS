using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class productoCTS
    {
        DatosProyMDIBFGestionTasasDP.productoCTS mproducto = new DatosProyMDIBFGestionTasasDP.productoCTS();
        public DataTable ListarProductoCTS(string CadenaConexion, string tipoproducto)
        {
            return mproducto.ListarProductoCTS(CadenaConexion, tipoproducto);
        }

        public DataTable BuscarProductoCTS(string CadenaConexion, string strtipoproducto, string strcodigo, string strnombres)
        {
            return mproducto.BuscarProductoCTS(CadenaConexion, strtipoproducto, strcodigo, strnombres);
        }
    }
}
