using EntidadProyMDIBFGestionTasas;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasas
{
    public class ProcesoCuentaSueldoCTS
    {
        DatosProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS mProcesoCuentaSueldoCTS = new DatosProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS();
        public bool EliminarCuentaSueldoCTS(string CadenaConexion)
        {
            return mProcesoCuentaSueldoCTS.EliminarCuentaSueldoCTS (CadenaConexion);
        }
    }
}
