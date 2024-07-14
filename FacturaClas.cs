using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    internal class FacturaClas
    {
        private int id_factura;
        private int id_cliente;
        private string id_auto;
        private string fecha;
        private int total;
        public bool existeF = false;
        private SqlCommand cmd = new SqlCommand();
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rentaCar.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn;

        public FacturaClas()
        {
            conn = new SqlConnection(strConn);
        }

        public FacturaClas(int Cid_Factura, int Cid_cliente, string Cid_auto, string Cfecha, int Ctotal)
        {
            this.id_factura = Cid_Factura;
            this.id_cliente = Cid_cliente;
            this.id_auto = Cid_auto;
            this.fecha = Cfecha;
            this.total = Ctotal;
            conn = new SqlConnection(strConn);
        }

        public int SId_factura
        {
            set { id_factura = value; }
            get { return id_factura; }
        }
        public int SId_cliente
        {
            set { id_cliente = value; }
            get { return id_cliente; }
        }
        public string SId_auto
        {
            set { id_auto = value; }
            get { return id_auto; }
        }
        public string SFecha
        {
            set { fecha = value; }
            get { return fecha; }
        }
        public int STotal
        {
            set { total = value; }
            get { return total; }
        }


        public void RegistrarFactura()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Factura_registro", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", SId_cliente);
                cmd.Parameters.AddWithValue("@id_factura", SId_factura);
                cmd.Parameters.AddWithValue("@id_auto", SId_auto);
                cmd.Parameters.AddWithValue("@fecha", SFecha);
                cmd.Parameters.AddWithValue("@total", STotal);
                int c = cmd.ExecuteNonQuery();


                if (c > 0)
                {
                    MessageBox.Show("Se registro la factura" + SFecha, "Exito", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { conn.Close(); }
        }

        public DataTable ListarFacturas()
        {
            try
            {
                DataSet ds;
                SqlDataAdapter da;
                conn.Open();
                cmd = new SqlCommand("ListarFacturas", conn);
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

        public void EliminarFactura()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("EliminarFactura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SId_factura);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Se eliminó la Factura: {SId_factura} ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningúna Factura con el ID " + SId_factura, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        public void BuscarFactura()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("BuscarFactura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SId_factura);
                SqlDataReader Leer = cmd.ExecuteReader();

                if (Leer.Read())
                {
                    existeF = true;
                    SId_factura = Convert.ToInt32(Leer["id_factura"]);
                    SId_cliente = Convert.ToInt32(Leer["fk_id_cliente"]);
                    SId_auto = Leer["fk_id_auto"].ToString();
                    SFecha = Leer["fecha"].ToString();
                    STotal = Convert.ToInt32(Leer["total"]);
                    Leer.Close();
                }
                else
                {
                    MessageBox.Show("Factura no encontrado en la Base de datos", "ERROR DE BUSQUEDA", MessageBoxButtons.OK);
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
    
        public void ActualizarFactura()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("ActualizarFactura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SId_factura);
                cmd.Parameters.AddWithValue("@total", STotal);

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

        public void UltimoId()
        {
            try
            {
                conn.Open();
                string Consulta = "select id_factura from factura order by id_factura desc";
                SqlCommand cmd = new SqlCommand(Consulta, conn);
                cmd.CommandType = CommandType.Text;

                int UltimoId = Convert.ToInt32(cmd.ExecuteScalar());

                SId_factura = UltimoId;
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

        public void ActualizarEstadoAuto()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("ActualizarUsoAuto", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placas", SId_auto);
                cmd.Parameters.AddWithValue("@NuevoEstado", "En Uso");
                cmd.ExecuteNonQuery();
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

        public List<string> ListarAutoLibre()
        {
            try
            {
                List<string> Carros = new List<string>();
                conn.Open();
                cmd = new SqlCommand("AutoLibre", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader Leer = cmd.ExecuteReader();

                while (Leer.Read())
                {
                    Carros.Add(Leer["id_auto"].ToString());
                }

                Leer.Close();
                return Carros;
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
