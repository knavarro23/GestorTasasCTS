using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class tipoproductoDP
    {
        DatosProyMDIBFGestionTasasDP.tipoproductoDP mtipoproducto = new DatosProyMDIBFGestionTasasDP.tipoproductoDP();
        public DataTable ListarTipoProducto(string CadenaConexion)
        {
            return mtipoproducto.ListarTipoProductoDP(CadenaConexion);
        }
    }
}
    