using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using NegocioWebDAO.Repositorios;


namespace DemoEntityFramework.Reportes
{
    public partial class WinReporte : Form
    {
        public WinReporte()
        {
            InitializeComponent();
        }

        private void WinReporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        void CargarInforme()
        {
            //Obtener la ruta del reporte
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string archivo = "RptPedidos.rdlc";
            string filereporte = ruta + "\\" + archivo;
            CompañiaDAO db = new CompañiaDAO();
            int cod = 0;
            DataSet ds = db.ListarP(0);

            reportViewer1.LocalReport.ReportPath = filereporte;

            ReportDataSource rs = new ReportDataSource("DsListarPedidoporEnvio",ds.Tables[0]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);

        } 
    }
}
