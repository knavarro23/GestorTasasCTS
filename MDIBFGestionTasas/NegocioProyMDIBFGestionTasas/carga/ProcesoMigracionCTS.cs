using EntidadProyMDIBFGestionTasas;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasas
{
    public class ProcesoMigracionCTS
    {
        DatosProyMDIBFGestionTasas.ProcesoMigracionCTS mProcesoMigracionCTS = new DatosProyMDIBFGestionTasas.ProcesoMigracionCTS();
        public bool EliminarMigracionCTS(string CadenaConexion)
        {
            return mProcesoMigracionCTS.EliminarMigracionCTS (CadenaConexion);
        }
    }
}
