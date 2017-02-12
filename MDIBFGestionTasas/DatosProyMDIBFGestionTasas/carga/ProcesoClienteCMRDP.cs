using System.Data.SqlClient;
using System.Data;
using System;

namespace DatosProyMDIBFGestionTasasDP
{
    public class ProcesoClienteCMRDP
    {
        public bool EliminarProcesoClienteCMRDP(string CadenaConexion)
        {
            bool resultado = true;
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = CadenaConexion;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MDIBF_ProcesoClienteCMRDP_Eliminar";

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message != "") resultado = false;
            }
            return resultado;
        }

    }
}
