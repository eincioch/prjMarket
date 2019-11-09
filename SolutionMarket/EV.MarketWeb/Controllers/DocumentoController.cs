using CrystalDecisions.CrystalReports.Engine;
using EV.DominioNet.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EV.MarketWeb.Controllers
{
    public class DocumentoController : Controller
    {
        public static IList<Documento> Documentos { get { return DataDocumento.Documentos; } }

        // GET: Documento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download_PDF()
        {
            //empEntities context = new empEntities();

            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/CrystalReport"), "rptDocumento.rpt"));
            rd.SetDataSource(Documentos.Select(c => new
            {
                IdDocumento = c.IdDocumento,
                cDescr = c.cDescr
            }).ToList());

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();

            rd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            rd.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(5, 5, 5, 5));
            rd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);

            return File(stream, "application/pdf", "DocumentoList.pdf");

            /*rd.SetDataSource(Documentos);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();


            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "DocumentoList.pdf");*/
        }
    }
}