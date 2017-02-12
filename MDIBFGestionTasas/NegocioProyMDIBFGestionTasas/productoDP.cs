using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class productoDP
    {
        DatosProyMDIBFGestionTasasDP.productoDP mproducto = new DatosProyMDIBFGestionTasasDP.productoDP();
        public DataTable ListarProductoDP(string CadenaConexion, string tipoproducto)
        {
            return mproducto.ListarProductoDP(CadenaConexion, tipoproducto);
        }
    }
}
