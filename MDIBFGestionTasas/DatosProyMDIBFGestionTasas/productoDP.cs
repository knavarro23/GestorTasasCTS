using System.Data.SqlClient;
using System.Data;

namespace DatosProyMDIBFGestionTasasDP
{
    public class productoDP
    {
        public DataTable ListarProductoDP(string CadenaConexion, string tipoproducto)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProductoDP_Listar";

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@tipoproducto", SqlDbType.VarChar,250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = tipoproducto;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "PRODUCTODP");
            cnn.Close();

            return ds.Tables["PRODUCTODP"];
        }
    }
}
