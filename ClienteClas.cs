using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    internal class ClienteClas
    {
        private int id;
        private string nombre;
        private string telefono;
        private string clasificacion;
        private int edad;
        private string licencia;
        private string tipoLicencia;
        private string fechaRegistro;
        public bool existe = false;
        private SqlCommand cmd = new SqlCommand();
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentaCar.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn;

        public ClienteClas()
        {
            conn = new SqlConnection(strConn);
        }

        public ClienteClas (int Cid, string nombre ,string telefono, string clasificacion, int edad, string licencia, string tipoLicencia, string fechaRegistro)
        {
            this.id = Cid;
            this.nombre = nombre;
            this.telefono = telefono;
            this.clasificacion = clasificacion;
            this.edad = edad;
            this.licencia = licencia;
            this.tipoLicencia = tipoLicencia;
            this.fechaRegistro = fechaRegistro;
            conn = new SqlConnection(strConn);

        }

        public int SId { get => id; set => id = value; }
        public string SNombre { get => nombre; set => nombre = value; }
        public string STelefono { get => telefono; set => telefono = value; }
        public string SClasificacion { get => clasificacion; set => clasificacion = value; }
        public int SEdad { get => edad; set => edad = value; }
        public string SLicencia { get => licencia; set => licencia = value; }
        public string STipoLicencia { get => tipoLicencia; set => tipoLicencia = value; }
        public string SFechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }

        public void EliminarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("EliminarCliente", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SId);
                cmd.Parameters.AddWithValue("@Nombre", SNombre);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Se eliminó el cliente: {SId} " + "\n" + $"Con Nombre: {SNombre} " , "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con el ID " + SId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataTable ListarClientes()
        {
            try
            {
                DataSet ds;
                SqlDataAdapter da;
                conn.Open();
                cmd = new SqlCommand("ListarClientes", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds.Tables[0];
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

        public void AgregarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("AgregarCliente", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SId);
                cmd.Parameters.AddWithValue("@Nombre", SNombre);
                cmd.Parameters.AddWithValue("@Telefono",STelefono);
                cmd.Parameters.AddWithValue("@Clasificacion", SClasificacion);
                cmd.Parameters.AddWithValue("@Edad", SEdad);
                cmd.Parameters.AddWithValue("@Licencia", SLicencia);
                cmd.Parameters.AddWithValue("@Tipo_licencia", STipoLicencia);
                cmd.Parameters.AddWithValue("@Fecha", SFechaRegistro);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente registrado", "informacion", MessageBoxButtons.OK);
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

        public void BuscarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("BuscarCliente", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdB",SId);
                cmd.Parameters.AddWithValue("@NombreB",SNombre);
                SqlDataReader Leer = cmd.ExecuteReader();
                
                if(Leer.Read()) 
                {
                    existe = true;
                    SId = Convert.ToInt32(Leer["id_cliente"]);
                    SNombre = Leer["nombre"].ToString();
                    STelefono = Leer["telefono"].ToString();
                    SClasificacion = Leer["clasificacion"].ToString();
                    SEdad = Convert.ToInt32(Leer["edad"]);
                    SLicencia = Leer["licencia"].ToString();
                    STipoLicencia = Leer["tipo_licencia"].ToString();
                    SFechaRegistro = Leer["fecha_registro"].ToString();
                    Leer.Close();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado en la Base de datos","ERROR DE BUSQUEDA",MessageBoxButtons.OK);
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

        public void ActualizarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("ActualizarClientes", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",SId);
                cmd.Parameters.AddWithValue("@Nombre", SNombre);
                cmd.Parameters.AddWithValue("@Telefono", STelefono);
                cmd.Parameters.AddWithValue("@Clasificacion", SClasificacion);
                cmd.Parameters.AddWithValue("@Edad", SEdad);
                cmd.Parameters.AddWithValue("@Licencia", SLicencia);
                cmd.Parameters.AddWithValue("@Tipo_licencia", SLicencia);

                int Afec = cmd.ExecuteNonQuery();

                if (Afec > 0)
                {
                    MessageBox.Show("Datos actualizados", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "ERROR", MessageBoxButtons.OK);
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

        public void UltimoIdCliente()
        {
            try
            {
                conn.Open();
                string Consulta = "select id_cliente from cliente order by id_cliente desc";
                SqlCommand cmd = new SqlCommand(Consulta, conn);
                cmd.CommandType = CommandType.Text;

                int UltimoId = Convert.ToInt32(cmd.ExecuteScalar());

                SId= UltimoId;
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
