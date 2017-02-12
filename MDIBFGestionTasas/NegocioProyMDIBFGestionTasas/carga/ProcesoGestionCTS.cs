using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasasDP
{
    public class ProcesoGestionCTS
    {
        DatosProyMDIBFGestionTasasDP.ProcesoGestionCTS mProcesoGestionCTS = new DatosProyMDIBFGestionTasasDP.ProcesoGestionCTS();
        public DataTable ReporteProcesoCTS(string CadenaConexion, string codigo)
        {
            return mProcesoGestionCTS.ReporteDatosCTS(CadenaConexion, codigo);
        }
        public DataTable ReporteProcesoTotalCTS(string CadenaConexion)
        {
            return mProcesoGestionCTS.ReporteDatosTotalCTS(CadenaConexion);
        }
    }
}
