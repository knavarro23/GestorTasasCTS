using EntidadProyMDIBFGestionTasas;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasas
{
    public class ProcesoAbonoQuintaCTS
    {
        DatosProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS mProcesoCuentaSueldoCTS = new DatosProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS();
        public bool EliminarAbonoQuintaCTS(string CadenaConexion)
        {
            return mProcesoCuentaSueldoCTS.EliminarAbonoQuintaCTS(CadenaConexion);
        }
    }
}
