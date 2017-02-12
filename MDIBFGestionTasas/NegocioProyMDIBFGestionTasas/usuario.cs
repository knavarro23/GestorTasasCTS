using EntidadProyMDIBFGestionTasasDP;
using DatosProyMDIBFGestionTasasDP;
using System.Data; 

namespace NegocioProyMDIBFGestionTasasDP
{
    public class usuario
    {
        DatosProyMDIBFGestionTasasDP.usuario mUsuario = new DatosProyMDIBFGestionTasasDP.usuario();
        public DataTable BuscarUsuario(string CadenaConexion, EntidadProyMDIBFGestionTasasDP.usuario Entidad)
        {
            return mUsuario.BuscarUsuario(CadenaConexion, Entidad);
        }
    }
}
