using EV.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EV.Market
{
    public partial class FormDocumento : Form
    {
        public IList<Documento> Documentos { get { return DataDocumento.Documentos; } }
        public FormDocumento()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void FormDocumento_Load(object sender, EventArgs e)
        {
            cboTipoDocu.DataSource = Documentos;
            cboTipoDocu.ValueMember = "IdDocumento";
            cboTipoDocu.DisplayMember = "cDescr";

            foreach (var item in Documentos)
            {
                ListViewItem items = new ListViewItem(item.IdDocumento.ToString());
                items.SubItems.Add(item.cDescr);
                //items.SubItems.Add(Convert.ToString(row["precio"]));

                listView1.Items.Add(items);
            }

        }

        private void cboTipoDocu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboTipoDocu.SelectedValue.ToString());
        }
    }
}
