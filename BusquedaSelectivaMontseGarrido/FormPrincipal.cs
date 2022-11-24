using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaSelectivaMontseGarrido
{
    public partial class FormPrincipal : Form
    {
        string cadenaConexion = "server=localhost; database=Montse; user id=sa; password=oretania";
        ArrayList celdas = new ArrayList();

        public FormPrincipal()
        {
            InitializeComponent();

            //Cambiamos el color de fondo, el color y el tipo de la letra al formulario
            BackColor = Color.FromArgb(184, 240, 237);
            ForeColor = Color.FromArgb(222, 120, 125);
            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectar();

            Estilos estilo = new Estilos(this.dgv);

            //Introducimos los diferetentes estilos
            estilo.definirFilas("#7adcd5", "#b8575e", "#50b4ad", "----------");
            estilo.definirCabecera("#7adcd5", "#50b4ad");
            estilo.definirFilarAlternas("#de787d", "#7adcd5", "**********");

            //Ajustamos el tamño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgv.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void conectar()
        {
            string sentencia = "SELECT * FROM formulario";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(sentencia, conexion);
                SqlDataReader dataReader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgv.DataSource = dt;
                comando.Dispose();
                conexion.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se puede realizar la conexión.");
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            celdas.Clear();
            buscarCoincidencias();
            
            if (celdas.Count > 0)
            {
                dgv.CurrentCell = (DataGridViewCell) celdas[0];
            } else
            {
                dgv.CurrentCell = dgv[0, 0];
            }
        }

        private void buscarCoincidencias()
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                foreach (DataGridViewCell celda in dgv.Rows[i].Cells)
                {
                    if (tbBuscar.Text != "" && celda.Value.ToString().Contains(tbBuscar.Text))
                    {
                        celdas.Add(celda);
                        celda.Style.BackColor = Color.White;
                    } else
                    {
                        celda.Style.BackColor = Color.FromArgb(184, 240, 237);
                    }
                }
            }
        }

        private void btIzq_Click(object sender, EventArgs e)
        {
            if (celdas.Count > 0)
            {
                int indice = celdas.IndexOf(dgv.CurrentCell);

                if (indice > 0)
                {
                    dgv.CurrentCell = (DataGridViewCell)celdas[indice - 1];
                }
            }
        }

        private void btDer_Click(object sender, EventArgs e)
        {
            if (celdas.Count > 0)
            {
                int indice = celdas.IndexOf(dgv.CurrentCell);

                if (indice < celdas.Count - 1)
                {
                    dgv.CurrentCell = (DataGridViewCell)celdas[indice + 1];
                }
            }
        }
    }
}
