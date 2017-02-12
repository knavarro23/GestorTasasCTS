using EntidadProyMDIBFGestionTasas;
using System.Data.SqlClient;
using System.Data;
using System;

namespace NegocioProyMDIBFGestionTasas
{
    public class ProcesoAbono360CTS
    {
        DatosProyMDIBFGestionTasas.ProcesoAbono360CTS mProcesoAbono360CTS = new DatosProyMDIBFGestionTasas.ProcesoAbono360CTS();
        public bool EliminarAbono360CTS(string CadenaConexion)
        {
            return mProcesoAbono360CTS.EliminarAbono360CTS(CadenaConexion);
        }
    }
}
