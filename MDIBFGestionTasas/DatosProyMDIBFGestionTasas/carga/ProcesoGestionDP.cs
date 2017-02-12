using System.Data.SqlClient;
using System.Data;
using System;

namespace DatosProyMDIBFGestionTasasDP
{
    public class ProcesoGestionDP
    {
        public bool EliminarProcesoGestionTasas(string CadenaConexion)
        {
            bool resultado = true;
            
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProcesoTasas_Eliminar";
               
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return resultado;
        }
        public DataTable BuscarProcesoDP(string CadenaConexion, string strcodprograma)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProcesoGestionDP_Buscar";

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@codigo", SqlDbType.VarChar,20);
            prm.Direction = ParameterDirection.Input;
            prm.Value = strcodprograma;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "PROCESO");
            cnn.Close();

            return ds.Tables["PROCESO"];
        }
        public DataTable ReporteDatosTotalDP(string CadenaConexion)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = CadenaConexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;  
                cmd.CommandText = "MDIBF_ProcesoGestionDP_Total";
                cmd.CommandTimeout = 5000000;
            
                var dataTable = new DataTable();

                cnn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dataTable.Load(dr);
                }
                
                cnn.Close();

                return dataTable;
                
            }
            catch (Exception ex)
            {
                throw;
            }
            
           
        }
    }
}
