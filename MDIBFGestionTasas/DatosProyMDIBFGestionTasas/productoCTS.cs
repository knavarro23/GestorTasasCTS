using System.Data.SqlClient;
using System.Data;
using System;

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

        public bool InsertarProductoCTS(string CadenaConexion, EntidadProyMDIBFGestionTasas.productoCTS Entidad)
        {
                bool resultado = true;

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = CadenaConexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MDIBF_ProductoCTS_Insertar";

                SqlParameter prm = new SqlParameter();

                prm = cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 50);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.codigo;

                prm = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 1000);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.nombre;

                prm = cmd.Parameters.Add("@tasa", SqlDbType.VarChar, 50);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.tasa;

                prm = cmd.Parameters.Add("@moneda", SqlDbType.VarChar, 250);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.moneda;

                prm = cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 1000);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.descripcion;

                prm = cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 250);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.tipo;

                prm = cmd.Parameters.Add("@tasasinpor", SqlDbType.VarChar, 50);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.tasasinpor;

                prm = cmd.Parameters.Add("@clase", SqlDbType.VarChar, 250);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.clase;

                prm = cmd.Parameters.Add("@activo", SqlDbType.Int);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.activo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                return resultado;
        }

        public bool ActualizarProductoCTS(string CadenaConexion, EntidadProyMDIBFGestionTasas.productoCTS Entidad)
        {
            bool resultado = true;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProductoCTS_Actualizar";

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@Id", SqlDbType.Int);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.productoCTSId;

            prm = cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 50);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.codigo;

            prm = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 1000);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.nombre;

            prm = cmd.Parameters.Add("@tasa", SqlDbType.VarChar, 50);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.tasa;

            prm = cmd.Parameters.Add("@moneda", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.moneda;

            prm = cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 1000);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.descripcion;

            prm = cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.tipo;

            prm = cmd.Parameters.Add("@tasasinpor", SqlDbType.VarChar, 50);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.tasasinpor;

            prm = cmd.Parameters.Add("@clase", SqlDbType.VarChar, 250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.clase;

            prm = cmd.Parameters.Add("@activo", SqlDbType.Int);
            prm.Direction = ParameterDirection.Input;
            prm.Value = Entidad.activo;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return resultado;
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

            prm = cmd.Parameters.Add("@tipoproducto", SqlDbType.VarChar, 250);
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

        public DataTable SeleccionarUnoProductoCTS(string CadenaConexion, int productoCTSId)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProductoCTS_SeleccionarUno";

            SqlParameter prm = new SqlParameter();
            prm = cmd.Parameters.Add("@productoCTSId", SqlDbType.Int);
            prm.Direction = ParameterDirection.Input;
            prm.Value = productoCTSId;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "PRODUCTOCTS");
            cnn.Close();

            return ds.Tables["PRODUCTOCTS"];
        }
    }
}
