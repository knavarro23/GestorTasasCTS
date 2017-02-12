﻿using System.Data.SqlClient;
using System.Data;
using System;


namespace DatosProyMDIBFGestionTasas
{
    public class ProcesoAbonoQuintaCTS
    {
        public bool EliminarAbonoQuintaCTS(string CadenaConexion)
        {
            bool resultado = true;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MDIBF_ProcesoAbonoQuintaCTS_Eliminar";

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return resultado;
        }
    }
}
