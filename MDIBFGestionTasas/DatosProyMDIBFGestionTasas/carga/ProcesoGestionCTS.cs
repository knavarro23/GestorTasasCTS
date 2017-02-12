using System.Data.SqlClient;
using System.Data;
using System;

namespace DatosProyMDIBFGestionTasasDP
{
    public class ProcesoGestionCTS
    {
        public DataTable ReporteDatosCTS(string CadenaConexion, string codigo)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProcesoGestionCTS_Buscar";
            cmd.CommandTimeout = 5000000;

            SqlParameter prm = new SqlParameter();

            prm = cmd.Parameters.Add("@codigo", SqlDbType.VarChar, 20);
            prm.Direction = ParameterDirection.Input;
            prm.Value = codigo;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "GestionCTS");
            cnn.Close();

            return ds.Tables["GestionCTS"];
        }

        public DataTable ReporteDatosTotalCTS(string CadenaConexion)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProcesoGestionCTS_Total";
            cmd.CommandTimeout = 5000000;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(ds, "GestionTotalCTS");
            cnn.Close();

            return ds.Tables["GestionTotalCTS"];
        }
    }
}
