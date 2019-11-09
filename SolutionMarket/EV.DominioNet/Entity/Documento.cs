using System;
using System.Collections.Generic;
using System.Text;

namespace EV.DominioNet.Entity
{
    public class Documento
    {
        public int IdDocumento { get; set; }
        public string cDescr { get; set; }
    }

    public class DataDocumento {

        public static IList<Documento> Documentos { get; private set; }

        static DataDocumento() {
            Documentos = new List<Documento>();

            Documentos.Add(new Documento { IdDocumento = 1, cDescr = "Boleta" });
            Documentos.Add(new Documento { IdDocumento = 2, cDescr = "Factura" });
        }
    }
}
