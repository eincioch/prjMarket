namespace EV.Market.Rpt
{
    partial class FormCrystalReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // FormCrystalReport
            // 
            this.ClientSize = new System.Drawing.Size(535, 436);
            this.Name = "FormCrystalReport";

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalRptVwr;

        /*
         this.CrystalRptVwr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystalRptVwr
            // 
            this.CrystalRptVwr.ActiveViewIndex = -1;
            this.CrystalRptVwr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalRptVwr.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalRptVwr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalRptVwr.Location = new System.Drawing.Point(0, 0);
            this.CrystalRptVwr.Name = "CrystalRptVwr";
            this.CrystalRptVwr.Size = new System.Drawing.Size(609, 413);
            this.CrystalRptVwr.TabIndex = 0;
            // 
            // FormCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Name = "FormCrystalReport";
            this.Controls.Add(this.CrystalRptVwr);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            */
    }
}