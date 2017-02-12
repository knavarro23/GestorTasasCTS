using EntidadProyMDIBFGestionTasasDP;
using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class responsable
    {
        DatosProyMDIBFGestionTasasDP.responsable mResponsable = new DatosProyMDIBFGestionTasasDP.responsable();
        public DataTable ListarResponsable(string CadenaConexion, EntidadProyMDIBFGestionTasasDP.responsable Entidad)
        {
            return mResponsable.ListarResponsable(CadenaConexion, Entidad);
        }
    }
}
