using CrystalDecisions.CrystalReports.Engine;
using EV.DominioNet.Entity;
using EV.MarkeNet.Rpt;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EV.MarkeNet.Maintenance
{
    public partial class FormDocumento : Form
    {
        public static IList<Documento> Documentos { get { return DataDocumento.Documentos; } }

        public FormDocumento()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //string startupPath = System.IO.Directory.GetCurrentDirectory();

            ReportDocument reportDocument = new ReportDocument();
#if DEBUG
            var ruta = "E:\\ExampleVS\\prjMarket\\SolutionMarket\\EV.MarkeNet\\rpt\\";
            reportDocument.Load($"{ruta}rptDocumento.rpt");
#else
            string startupPath = Environment.CurrentDirectory;
            var ruta = startupPath;
            reportDocument.Load($startupPath {"\\rpt\\rptDocumento.rpt"});
#endif
            reportDocument.Refresh();

            //CrReport.DataDefinition.FormulaFields("rangofec").Text = Chr(34) & "Desde: " & Format(DtpFecIni.Value, "dd/MM/yyyy") & " hasta " & Format(DtpFecFin.Value, "dd/MM/yyyy") & Chr(34)

            reportDocument.SetDataSource(Documentos);

            FormCrystalReport frm = new FormCrystalReport();
            frm.Text = "Reporte documento";

            frm.CrystalRptVwr.ReportSource = reportDocument;
            //Directo a la impresora
            //frm.CrystalRptVwr.PrintReport()
            frm.Show();
        }

        private void FormDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
