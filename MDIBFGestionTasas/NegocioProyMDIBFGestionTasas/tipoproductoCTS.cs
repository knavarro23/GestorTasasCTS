using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class tipoproductoCTS
    {
        DatosProyMDIBFGestionTasasDP.tipoproductoCTS mtipoproductoCTS = new DatosProyMDIBFGestionTasasDP.tipoproductoCTS();
        public DataTable ListarTipoProductoCTS(string CadenaConexion)
        {
            return mtipoproductoCTS.ListarTipoProductoCTS(CadenaConexion);
        }
    }
}
