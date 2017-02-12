using System.Data.SqlClient;
using System.Data;
using System;

namespace DatosProyMDIBFGestionTasasDP
{
    public class proceso
    {
        public int InsertarProceso(string CadenaConexion, EntidadProyMDIBFGestionTasasDP.proceso Entidad)
        {
            int insertar = 0;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = CadenaConexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MDIBF_Proceso_Insertar";
                SqlParameter prm = new SqlParameter();

                prm = cmd.Parameters.Add("@responsableId", SqlDbType.Int);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.responsableId;

                prm = cmd.Parameters.Add("@nombrearchivo", SqlDbType.VarChar, 2000);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.nombrearchivo;

                prm = cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 20);
                prm.Direction = ParameterDirection.Input;
                prm.Value = Entidad.tipo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message != "") insertar = 1;
            }
            return insertar;
        }

        //public int EliminarProceso(string CadenaConexion, int procesoId)
        //{
        //    int insertar = 0;

        //    SqlConnection cnn = new SqlConnection();
        //    cnn.ConnectionString = CadenaConexion;
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "MDIBF_Proceso_Eliminar";
        //    SqlParameter prm = new SqlParameter();

        //    prm = cmd.Parameters.Add("@procesoId", SqlDbType.Int);
        //    prm.Direction = ParameterDirection.Input;
        //    prm.Value = procesoId;

        //    cnn.Open();
        //    cmd.ExecuteNonQuery();
        //    cnn.Close();

        //    return insertar;
        //}
        //public DataTable BuscarProceso(string CadenaConexion,int responsableId, DateTime? dtinicio, DateTime? dtfinal)
        //{
        //    SqlConnection cnn = new SqlConnection();
        //    cnn.ConnectionString = CadenaConexion;
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cnn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "MDIBF_Proceso_Buscar";

        //    SqlParameter prm = new SqlParameter();
           
        //    prm = cmd.Parameters.Add("@responsableId", SqlDbType.Int);
        //    prm.Direction = ParameterDirection.Input;
        //    prm.Value = responsableId;

        //    prm = cmd.Parameters.Add("@dtinicio", SqlDbType.DateTime);
        //    prm.Direction = ParameterDirection.Input;
        //    prm.Value = null;

        //    prm = cmd.Parameters.Add("@dtfinal", SqlDbType.DateTime);
        //    prm.Direction = ParameterDirection.Input;
        //    prm.Value = null;

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    cnn.Open();
        //    da.Fill(ds, "PROCESO");
        //    cnn.Close();

        //    return ds.Tables["PROCESO"];
        //}

        public DataTable ListarProceso(string CadenaConexion, string strtipo)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_Proceso_Informacion";

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@tipo", SqlDbType.VarChar,250);
            prm.Direction = ParameterDirection.Input;
            prm.Value = strtipo;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "PROCESO");
            cnn.Close();

            return ds.Tables["PROCESO"];
        }
    }
}
