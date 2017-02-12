using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasasDP
{
    public class proceso
    {
        DatosProyMDIBFGestionTasasDP.proceso mProceso = new DatosProyMDIBFGestionTasasDP.proceso();
        public int InsertarProceso(string CadenaConexion, EntidadProyMDIBFGestionTasasDP.proceso Entidad)
        {
            return mProceso.InsertarProceso(CadenaConexion, Entidad);
        }
        public DataTable ListarProceso(string CadenaConexion, string strTipo)
        {
            return mProceso.ListarProceso(CadenaConexion, strTipo);
        }

        //public int EliminarProceso(string CadenaConexion, int procesoId)
        //{
        //    return mProceso.EliminarProceso(CadenaConexion, procesoId);
        //}
        //public DataTable BusquedaProceso(string CadenaConexion, int responsableId, DateTime? dtinicio, DateTime? dtfinal)
        //{
        //    return mProceso.BuscarProceso(CadenaConexion, responsableId, dtinicio, dtfinal);
        //}
    }
}
