using EV.Market.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EV.Market
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        private void btnMaintenanceDocumento_Click(object sender, EventArgs e)
        {
            var frmDocu = new FormDocumento();
            frmDocu.ShowDialog();
        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {

        }
    }
}
