using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasasDP
{
    public class ProcesoGestionDP
    {
        DatosProyMDIBFGestionTasasDP.ProcesoGestionDP mProcesoGestionDP = new DatosProyMDIBFGestionTasasDP.ProcesoGestionDP();
        public bool EliminarProcesoGestionTasas(string CadenaConexion)
        {
            return mProcesoGestionDP.EliminarProcesoGestionTasas(CadenaConexion);
        }
        public DataTable BusquedaProcesoDP(string CadenaConexion, string strcodprograma)
        {
            return mProcesoGestionDP.BuscarProcesoDP(CadenaConexion, strcodprograma);
        }
        public DataTable ReporteProcesoDP(string CadenaConexion, string strcodprograma)
        {
            return mProcesoGestionDP.BuscarProcesoDP(CadenaConexion, strcodprograma);
        }
        public DataTable ReporteProcesoTotalDP(string CadenaConexion)
        {
            return mProcesoGestionDP.ReporteDatosTotalDP(CadenaConexion);
        }
    }
}
