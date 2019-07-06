using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NegocioWebDAO.Repositorios;
using NegocioWebDAO.Entidades;

namespace DemoEntityFramework.Mantenimientos
{
    
    public partial class WinCompañias : Form
    {
        public int codigo;
        public WinCompañias()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtID.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Compañías_de_envíos comp  = new Compañías_de_envíos();
            CompañiaDAO compañia = new CompañiaDAO();
            comp.IdCompañíaEnvíos = Convert.ToInt32(txtID.Text);
            comp.NombreCompañía = txtNombre.Text;
            comp.Teléfono = txtTelefono.Text;
            compañia.Agregar(comp);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = compañia.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compañías_de_envíos comp = new Compañías_de_envíos();
            CompañiaDAO compañia = new CompañiaDAO();
            int codcom = Convert.ToInt32(txtID.Text);
            txtTelefono.Text = compañia.Buscar(codcom).Teléfono;
            txtNombre.Text = compañia.Buscar(codcom).NombreCompañía;
            groupBox1.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Compañías_de_envíos comp = new Compañías_de_envíos();
            CompañiaDAO compañia = new CompañiaDAO();
            comp.IdCompañíaEnvíos = Convert.ToInt32(txtID.Text);
            comp.NombreCompañía = txtNombre.Text;
            comp.Teléfono = txtTelefono.Text;
            compañia.Editar(comp);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = compañia.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CompañiaDAO compañia = new CompañiaDAO();
            int codcom = Convert.ToInt32(txtID.Text);
            compañia.Eliminar(codcom);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = compañia.Listar();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            CompañiaDAO compañia = new CompañiaDAO();
            int codcom = Convert.ToInt32(txtID.Text);
            txtTelefono.Text = compañia.Buscar(codcom).Teléfono;
            txtNombre.Text = compañia.Buscar(codcom).NombreCompañía;
            compañia.ListarP(codcom);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = compañia.ListarP(codcom);

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.WinReporte frm = new Reportes.WinReporte();
            frm.ShowDialog();
            codigo = Convert.ToInt32(txtID.Text);
        }

        private void WinCompañias_Load(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(txtID.Text);
        }
    }
}