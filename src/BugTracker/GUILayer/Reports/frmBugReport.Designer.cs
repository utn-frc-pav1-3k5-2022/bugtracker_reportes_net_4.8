namespace BugTracker.GUILayer.Reports
{
    partial class frmBugReport
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
            this.components = new System.ComponentModel.Container();
            this.BugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rpvBugs = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BugsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BugsBindingSource
            // 
            this.BugsBindingSource.DataMember = "Bugs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaHasta);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtFechaDesde);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(354, 19);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(180, 20);
            this.txtFechaHasta.TabIndex = 17;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(282, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 13);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Fecha Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Fecha desde:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(81, 19);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(181, 20);
            this.txtFechaDesde.TabIndex = 14;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(582, 19);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rpvBugs
            // 
            this.rpvBugs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBugs.LocalReport.ReportEmbeddedResource = "BugTracker.GUILayer.Reports.ReporteBugs.rdlc";
            this.rpvBugs.Location = new System.Drawing.Point(0, 66);
            this.rpvBugs.Name = "rpvBugs";
            this.rpvBugs.ServerReport.BearerToken = null;
            this.rpvBugs.Size = new System.Drawing.Size(800, 384);
            this.rpvBugs.TabIndex = 2;
            // 
            // frmBugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvBugs);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBugReport";
            this.Text = "frmBugReport";
            this.Load += new System.EventHandler(this.frmBugReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BugsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BugsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerar;
        internal System.Windows.Forms.MaskedTextBox txtFechaHasta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBugs;
    }
}