﻿namespace EV.Market
{
    partial class FormContenedor
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMaintenanceDocumento = new System.Windows.Forms.Button();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-186, -16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-100, -16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMaintenanceDocumento
            // 
            this.btnMaintenanceDocumento.Location = new System.Drawing.Point(79, 59);
            this.btnMaintenanceDocumento.Name = "btnMaintenanceDocumento";
            this.btnMaintenanceDocumento.Size = new System.Drawing.Size(125, 77);
            this.btnMaintenanceDocumento.TabIndex = 3;
            this.btnMaintenanceDocumento.Text = "Documentos";
            this.btnMaintenanceDocumento.UseVisualStyleBackColor = true;
            this.btnMaintenanceDocumento.Click += new System.EventHandler(this.btnMaintenanceDocumento_Click);
            // 
            // FormContenedor
            // 
            this.ClientSize = new System.Drawing.Size(651, 446);
            this.Controls.Add(this.btnMaintenanceDocumento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormContenedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormContenedor_Load);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMaintenanceDocumento;
    }
}