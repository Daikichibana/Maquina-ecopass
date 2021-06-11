using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina
{
    public partial class inicioSesion : Form
    {
        Usuario usuario;
        Estado estado;
        public inicioSesion()
        {
            InitializeComponent();
            usuario = new Usuario();
            estado = new Estado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                usuario.cargarDatos(int.Parse(txtID.Text));
                estado.cargarEstado(int.Parse(txtID.Text));
                if (usuario.Id != null && estado.Puntos != null)
                {

                    if (usuario.Id.Equals(txtID.Text))
                    {
                        CargarPuntos cp = new CargarPuntos();

                        cp.lblID.Text = usuario.Id.ToString();
                        cp.lblUsuario.Text = usuario.Nombre + " " + usuario.Apellido;
                        cp.lblPuntos.Text = estado.Puntos;
                        cp.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No existe el ID en nuestra bases de datos.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un dato.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
