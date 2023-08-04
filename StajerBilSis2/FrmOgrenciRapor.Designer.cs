namespace StajerBilSis2
{
    partial class FrmOgrenciRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciRapor));
            this.stajyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerBilgiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerBilgiDataSet1 = new StajerBilSis2.StajyerBilgiDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.stajyerTableAdapter = new StajerBilSis2.StajyerBilgiDataSet1TableAdapters.StajyerTableAdapter();
            this.stajyerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerBilgiDataSet9 = new StajerBilSis2.StajyerBilgiDataSet9();
            this.stajyerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerTableAdapter1 = new StajerBilSis2.StajyerBilgiDataSet9TableAdapters.StajyerTableAdapter();
            this.stajyerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // stajyerBindingSource
            // 
            this.stajyerBindingSource.DataMember = "Stajyer";
            this.stajyerBindingSource.DataSource = this.stajyerBilgiDataSet1BindingSource;
            // 
            // stajyerBilgiDataSet1BindingSource
            // 
            this.stajyerBilgiDataSet1BindingSource.DataSource = this.stajyerBilgiDataSet1;
            this.stajyerBilgiDataSet1BindingSource.Position = 0;
            // 
            // stajyerBilgiDataSet1
            // 
            this.stajyerBilgiDataSet1.DataSetName = "StajyerBilgiDataSet1";
            this.stajyerBilgiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.stajyerBindingSource4;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StajerBilSis2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // stajyerTableAdapter
            // 
            this.stajyerTableAdapter.ClearBeforeFill = true;
            // 
            // stajyerBindingSource1
            // 
            this.stajyerBindingSource1.DataMember = "Stajyer";
            this.stajyerBindingSource1.DataSource = this.stajyerBilgiDataSet1BindingSource;
            // 
            // stajyerBindingSource2
            // 
            this.stajyerBindingSource2.DataMember = "Stajyer";
            this.stajyerBindingSource2.DataSource = this.stajyerBilgiDataSet1BindingSource;
            // 
            // stajyerBilgiDataSet9
            // 
            this.stajyerBilgiDataSet9.DataSetName = "StajyerBilgiDataSet9";
            this.stajyerBilgiDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stajyerBindingSource3
            // 
            this.stajyerBindingSource3.DataMember = "Stajyer";
            this.stajyerBindingSource3.DataSource = this.stajyerBilgiDataSet9;
            // 
            // stajyerTableAdapter1
            // 
            this.stajyerTableAdapter1.ClearBeforeFill = true;
            // 
            // stajyerBindingSource4
            // 
            this.stajyerBindingSource4.DataMember = "Stajyer";
            this.stajyerBindingSource4.DataSource = this.stajyerBilgiDataSet1BindingSource;
            // 
            // FrmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciRapor";
            this.Text = "Stajyer Raporu";
            this.Load += new System.EventHandler(this.FrmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource stajyerBilgiDataSet1BindingSource;
        private StajyerBilgiDataSet1 stajyerBilgiDataSet1;
        private System.Windows.Forms.BindingSource stajyerBindingSource;
        private StajyerBilgiDataSet1TableAdapters.StajyerTableAdapter stajyerTableAdapter;
        private System.Windows.Forms.BindingSource stajyerBindingSource1;
        private System.Windows.Forms.BindingSource stajyerBindingSource2;
        private StajyerBilgiDataSet9 stajyerBilgiDataSet9;
        private System.Windows.Forms.BindingSource stajyerBindingSource3;
        private StajyerBilgiDataSet9TableAdapters.StajyerTableAdapter stajyerTableAdapter1;
        private System.Windows.Forms.BindingSource stajyerBindingSource4;
    }
}