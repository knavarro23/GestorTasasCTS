using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;

namespace DatosProyMDIBFGestionTasasDP
{
    public class tipoproductoCTS
    {
        public DataTable ListarTipoProductoCTS(string CadenaConexion)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_TipoProductoCTS_Listar";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "TIPOPRODUCTOCTS");
            cnn.Close();

            return ds.Tables["TIPOPRODUCTOCTS"];
        }
    }
}
