using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;
using System;


namespace NegocioProyMDIBFGestionTasasDP
{
    public class ProcesoClienteCMRDP
    {
        DatosProyMDIBFGestionTasasDP.ProcesoClienteCMRDP mProcesoClienteCMRDP = new DatosProyMDIBFGestionTasasDP.ProcesoClienteCMRDP();
        public bool EliminarProcesoClienteCMRDP(string CadenaConexion)
        {
            return mProcesoClienteCMRDP.EliminarProcesoClienteCMRDP(CadenaConexion);
        }
    }
}
