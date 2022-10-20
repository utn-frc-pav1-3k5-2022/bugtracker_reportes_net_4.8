using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.GUILayer.Reports
{
    public partial class frmBugReport : Form
    {
        public frmBugReport()
        {
            InitializeComponent();
        }

        private void frmBugReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Bugs' Puede moverla o quitarla según sea necesario.

            this.rpvBugs.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT t2.nombre as producto, t3.nombre as estado, COUNT(*) as cantidad " +
                             "FROM Bugs t1, Productos t2, Estados t3 " +
                             "WHERE t1.id_producto = t2.id_producto " +
                             "AND t1.id_estado = t3.id_estado " +
                             "AND t1.fecha_alta between @fechaDesde AND @fechaHasta " +
                             "GROUP BY t2.nombre, t3.nombre";


            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                parametros.Add("fechaDesde", fechaDesde);
                parametros.Add("fechaHasta", fechaHasta);

                rpvBugs.LocalReport.SetParameters(new ReportParameter[] {
                    new ReportParameter("prFechaDesde", fechaDesde.ToString("dd/MM/yyyy")),
                    new ReportParameter("prFechaHasta", fechaHasta.ToString("dd/MM/yyyy"))
                });

                //DATASOURCE
                rpvBugs.LocalReport.DataSources.Clear();
                rpvBugs.LocalReport.DataSources.Add(new ReportDataSource("DSReporte", DataManager.GetInstance().ConsultaSQL(strSql, parametros)));
                rpvBugs.RefreshReport();
            }
        }
    }
}
