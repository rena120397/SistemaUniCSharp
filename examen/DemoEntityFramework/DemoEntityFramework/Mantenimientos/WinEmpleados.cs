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
    public partial class WinEmpleados : Form
    {
        public WinEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs emp)
        {
            Empleado empe = new Empleado();
            EmpleadoDAO empleados = new EmpleadoDAO();
            empe.IdEmpleado= Convert.ToInt32(txtID.Text);
            empe.Nombre= txtNombre.Text;
            empe.Apellidos = txtApellidos.Text;
            empe.FechaNacimiento = Convert.ToDateTime(txtFechaN.Text);
            empe.FechaContratación = Convert.ToDateTime(txtFechaC.Text);
            empe.Cargo = txtCargo.Text;
            empe.Dirección = txtDireccion.Text;
            empe.Ciudad = txtCiudad.Text;
            empe.País = txtPais.Text;
            empe.TelDomicilio = txtTel.Text;
            empe.Foto = txtFoto.Text;
            empleados.Agregar(empe);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empe = new Empleado();
            EmpleadoDAO empleados = new EmpleadoDAO();
            empe.IdEmpleado = Convert.ToInt32(txtID.Text);
            empe.Nombre = txtNombre.Text;
            empe.Apellidos = txtApellidos.Text;
            empe.FechaNacimiento = Convert.ToDateTime(txtFechaN.Text);
            empe.FechaContratación = Convert.ToDateTime(txtFechaC.Text);
            empe.Cargo = txtCargo.Text;
            empe.Dirección = txtDireccion.Text;
            empe.Ciudad = txtCiudad.Text;
            empe.País = txtPais.Text;
            empe.TelDomicilio = txtTel.Text;
            empe.Foto = txtFoto.Text;
            empleados.Editar(empe);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados.Listar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpleadoDAO empleados = new EmpleadoDAO();
            Empleado empe = new Empleado();
            int codemp = Convert.ToInt32(txtID.Text); 
            txtApellidos.Text = empleados.Buscar(codemp).Apellidos;
            txtNombre.Text = empleados.Buscar(codemp).Nombre;
            txtCargo.Text = empleados.Buscar(codemp).Cargo;
            txtCiudad.Text = empleados.Buscar(codemp).Ciudad;
            txtDireccion.Text = empleados.Buscar(codemp).Dirección;
            txtFechaC.Text = empleados.Buscar(codemp).FechaContratación.ToString();
            txtFechaN.Text = empleados.Buscar(codemp).FechaNacimiento.ToString();
            txtFoto.Text = empleados.Buscar(codemp).Foto;
            txtPais.Text = empleados.Buscar(codemp).País;
            txtTel.Text = empleados.Buscar(codemp).TelDomicilio;
            groupBox1.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EmpleadoDAO empleados = new EmpleadoDAO();
            int codemp = Convert.ToInt32(txtID.Text);
            empleados.Eliminar(codemp);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados.Listar();
        }

        private void WinEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
