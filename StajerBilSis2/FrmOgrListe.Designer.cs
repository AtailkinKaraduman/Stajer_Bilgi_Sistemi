namespace StajerBilSis2
{
    partial class FrmOgrListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stajyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajyerBilgiDataSet5 = new StajerBilSis2.StajyerBilgiDataSet5();
            this.stajyerTableAdapter = new StajerBilSis2.StajyerBilgiDataSet5TableAdapters.StajyerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn,
            this.ogrBasDataGridViewTextBoxColumn,
            this.ogrBitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stajyerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogridDataGridViewTextBoxColumn.Width = 135;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            // 
            // ogrBasDataGridViewTextBoxColumn
            // 
            this.ogrBasDataGridViewTextBoxColumn.DataPropertyName = "OgrBas";
            this.ogrBasDataGridViewTextBoxColumn.HeaderText = "OgrBas";
            this.ogrBasDataGridViewTextBoxColumn.Name = "ogrBasDataGridViewTextBoxColumn";
            this.ogrBasDataGridViewTextBoxColumn.Width = 135;
            // 
            // ogrBitDataGridViewTextBoxColumn
            // 
            this.ogrBitDataGridViewTextBoxColumn.DataPropertyName = "OgrBit";
            this.ogrBitDataGridViewTextBoxColumn.HeaderText = "OgrBit";
            this.ogrBitDataGridViewTextBoxColumn.Name = "ogrBitDataGridViewTextBoxColumn";
            this.ogrBitDataGridViewTextBoxColumn.Width = 135;
            // 
            // stajyerBindingSource
            // 
            this.stajyerBindingSource.DataMember = "Stajyer";
            this.stajyerBindingSource.DataSource = this.stajyerBilgiDataSet5;
            // 
            // stajyerBilgiDataSet5
            // 
            this.stajyerBilgiDataSet5.DataSetName = "StajyerBilgiDataSet5";
            this.stajyerBilgiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stajyerTableAdapter
            // 
            this.stajyerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrListe";
            this.Text = "FrmOgrList";
            this.Load += new System.EventHandler(this.FrmOgrList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerBilgiDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StajyerBilgiDataSet5 stajyerBilgiDataSet5;
        private System.Windows.Forms.BindingSource stajyerBindingSource;
        private StajyerBilgiDataSet5TableAdapters.StajyerTableAdapter stajyerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBitDataGridViewTextBoxColumn;
    }
}