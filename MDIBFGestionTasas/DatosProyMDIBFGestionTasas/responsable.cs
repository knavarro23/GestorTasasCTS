using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;

namespace DatosProyMDIBFGestionTasasDP
{
    public class responsable
    {
        public DataTable ListarResponsable(string CadenaConexion, EntidadProyMDIBFGestionTasasDP.responsable Entidad)
        {

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_Responsable_Listar";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "RESPONSABLE");
            cnn.Close();

            return ds.Tables["RESPONSABLE"];
        }
    }
}
