using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioProyMDIBFGestionTasas
{
    public class ProcesoContactoCTS
    {
        DatosProyMDIBFGestionTasas.ProcesoContactoCTS mProcesoContactoCTS = new DatosProyMDIBFGestionTasas.ProcesoContactoCTS();
        public bool EliminarContactoCTS(string CadenaConexion)
        {
            return mProcesoContactoCTS.EliminarContactoCTS(CadenaConexion);
        }
    }
}
