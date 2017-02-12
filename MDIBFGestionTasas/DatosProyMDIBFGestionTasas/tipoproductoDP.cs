using EntidadProyMDIBFGestionTasasDP;
using System.Data.SqlClient;
using System.Data;

namespace DatosProyMDIBFGestionTasasDP
{
    public class tipoproductoDP
    {
        public DataTable ListarTipoProductoDP(string CadenaConexion)
        {

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_TipoProductoDP_Listar";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "TIPOPRODUCTODP");
            cnn.Close();

            return ds.Tables["TIPOPRODUCTODP"];
        }
    }
}
