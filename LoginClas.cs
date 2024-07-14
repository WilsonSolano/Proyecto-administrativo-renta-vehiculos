using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PantallaPrincipa
{
    internal class LoginClas
    {
        private string contraseña, usuario;
        public bool existe = false;
        private SqlCommand cmd = new SqlCommand();
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentaCar.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn;

        public LoginClas()
        {
            conn = new SqlConnection(strConn);
        }

        public LoginClas(string Vcontraseña, string Vusuario)
        {
            this.contraseña = Vcontraseña;
            this.usuario = Vusuario;
            conn = new SqlConnection(strConn);
        }

        public string GUsuario { get => usuario; set => usuario = value; }
        public string GContraseña { get => contraseña; set => contraseña = value; }
    
        public void inicia()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Login", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", GUsuario);
                cmd.Parameters.AddWithValue("@contra", GContraseña);
                cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        existe = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
