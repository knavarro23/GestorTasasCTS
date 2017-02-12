using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;

namespace DatosProyMDIBFGestionTasasDP
{
    public class usuario
    {
        public DataTable BuscarUsuario(string CadenaConexion, EntidadProyMDIBFGestionTasasDP.usuario Entidad)
        {

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_Usuario_Buscar";
            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.username;

            prm = cmd.Parameters.Add("@password", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.password;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "USUARIO");
            cnn.Close();

            return ds.Tables["USUARIO"];
        }
    }
}
