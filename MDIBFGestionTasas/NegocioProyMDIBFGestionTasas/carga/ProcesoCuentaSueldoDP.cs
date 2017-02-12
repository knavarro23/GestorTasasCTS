using EntidadProyMDIBFGestionTasas;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasasDP
{
    public class ProcesoCuentaSueldoDP
    {
        DatosProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP mProcesoCuentaSueldoDP = new DatosProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP();

        public bool EliminarCuentaSueldoDP(string CadenaConexion)
        {
            return mProcesoCuentaSueldoDP.EliminarCuentaSueldoDP(CadenaConexion);
        }
    }
}
