using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace ProyectoDISCOsql
{
    public partial class Form1 : Form
    {

        private List<Discos> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            DiscoNegocio negocio = new DiscoNegocio();

            listaDiscos = negocio.listar();
            

            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["urlImagen"].Visible = false;
            cargarImagen (listaDiscos[0].urlImagen);

        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos discoSeleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen (discoSeleccionado.urlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);

            }
            catch (Exception )
            {

                pbxDiscos.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }

        }

        
    }
}
