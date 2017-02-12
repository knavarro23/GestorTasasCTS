using System.Data.SqlClient;
using System.Data;

namespace DatosProyMDIBFGestionTasasDP
{
    public class productoCTS
    {
        public DataTable ListarProductoCTS(string CadenaConexion, string tipoproducto)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProductoCTS_Listar";

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@tipoproducto", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = tipoproducto;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "PRODUCTOCTS");
            cnn.Close();

            return ds.Tables["PRODUCTOCTS"];
        }

        public DataTable BuscarProductoCTS(string CadenaConexion, string strtipoproducto, string strcodigo, string strnombres)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProductoCTS_Buscar";

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = strtipoproducto;

            prm = cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 50);
            prm.Direction = ParameterDirection.Input;
            prm.Value = strcodigo;

            prm = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 1000);
            prm.Direction = ParameterDirection.Input;
            prm.Value = strnombres;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "PRODUCTOCTS");
            cnn.Close();

            return ds.Tables["PRODUCTOCTS"];
        }
    }
}
