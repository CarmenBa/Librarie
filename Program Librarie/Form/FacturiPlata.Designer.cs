﻿namespace Program_Librarie
{
    partial class FacturiPlata
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
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPlataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platadetaliuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.platadetaliuTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.platadetaliuTableAdapter();
            this.tbValMin = new System.Windows.Forms.NumericUpDown();
            this.tbValMax = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platadetaliuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValMax)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(184, 8);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(189, 28);
            this.cmbFurnizor.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "Furnizor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Valoare minimă";
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(409, 20);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(170, 38);
            this.btnCauta.TabIndex = 69;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Valoare maximă";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlataDataGridViewTextBoxColumn,
            this.serieDocumentDataGridViewTextBoxColumn,
            this.nrDocumentDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.idFurnizorDataGridViewTextBoxColumn,
            this.furnizorDataGridViewTextBoxColumn,
            this.idAchizitieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.platadetaliuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 414);
            this.dataGridView1.TabIndex = 76;
            // 
            // idPlataDataGridViewTextBoxColumn
            // 
            this.idPlataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPlataDataGridViewTextBoxColumn.DataPropertyName = "IdPlata";
            this.idPlataDataGridViewTextBoxColumn.HeaderText = "IdPlata";
            this.idPlataDataGridViewTextBoxColumn.Name = "idPlataDataGridViewTextBoxColumn";
            this.idPlataDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlataDataGridViewTextBoxColumn.Width = 65;
            // 
            // serieDocumentDataGridViewTextBoxColumn
            // 
            this.serieDocumentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serieDocumentDataGridViewTextBoxColumn.DataPropertyName = "SerieDocument";
            this.serieDocumentDataGridViewTextBoxColumn.HeaderText = "SerieDocument";
            this.serieDocumentDataGridViewTextBoxColumn.Name = "serieDocumentDataGridViewTextBoxColumn";
            this.serieDocumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDocumentDataGridViewTextBoxColumn.Width = 105;
            // 
            // nrDocumentDataGridViewTextBoxColumn
            // 
            this.nrDocumentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrDocumentDataGridViewTextBoxColumn.DataPropertyName = "NrDocument";
            this.nrDocumentDataGridViewTextBoxColumn.HeaderText = "NrDocument";
            this.nrDocumentDataGridViewTextBoxColumn.Name = "nrDocumentDataGridViewTextBoxColumn";
            this.nrDocumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrDocumentDataGridViewTextBoxColumn.Width = 92;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumaDataGridViewTextBoxColumn.Width = 59;
            // 
            // idFurnizorDataGridViewTextBoxColumn
            // 
            this.idFurnizorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idFurnizorDataGridViewTextBoxColumn.DataPropertyName = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.HeaderText = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.Name = "idFurnizorDataGridViewTextBoxColumn";
            this.idFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFurnizorDataGridViewTextBoxColumn.Visible = false;
            // 
            // furnizorDataGridViewTextBoxColumn
            // 
            this.furnizorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.furnizorDataGridViewTextBoxColumn.DataPropertyName = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn.HeaderText = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn.Name = "furnizorDataGridViewTextBoxColumn";
            this.furnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.furnizorDataGridViewTextBoxColumn.Width = 69;
            // 
            // idAchizitieDataGridViewTextBoxColumn
            // 
            this.idAchizitieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idAchizitieDataGridViewTextBoxColumn.DataPropertyName = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn.HeaderText = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn.Name = "idAchizitieDataGridViewTextBoxColumn";
            this.idAchizitieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAchizitieDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 55;
            // 
            // platadetaliuBindingSource
            // 
            this.platadetaliuBindingSource.DataMember = "platadetaliu";
            this.platadetaliuBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // platadetaliuTableAdapter
            // 
            this.platadetaliuTableAdapter.ClearBeforeFill = true;
            // 
            // tbValMin
            // 
            this.tbValMin.DecimalPlaces = 2;
            this.tbValMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbValMin.Location = new System.Drawing.Point(184, 42);
            this.tbValMin.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbValMin.Name = "tbValMin";
            this.tbValMin.Size = new System.Drawing.Size(189, 26);
            this.tbValMin.TabIndex = 77;
            this.tbValMin.ThousandsSeparator = true;
            // 
            // tbValMax
            // 
            this.tbValMax.DecimalPlaces = 2;
            this.tbValMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbValMax.Location = new System.Drawing.Point(184, 74);
            this.tbValMax.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbValMax.Name = "tbValMax";
            this.tbValMax.Size = new System.Drawing.Size(189, 26);
            this.tbValMax.TabIndex = 78;
            this.tbValMax.ThousandsSeparator = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(409, 62);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 38);
            this.btnReset.TabIndex = 79;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FacturiPlata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(775, 548);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbValMax);
            this.Controls.Add(this.tbValMin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbFurnizor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacturiPlata";
            this.Text = "FacturiPlata";
            this.Load += new System.EventHandler(this.FacturiPlata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platadetaliuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFurnizor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource platadetaliuBindingSource;
        private LibrarieDataSetTableAdapters.platadetaliuTableAdapter platadetaliuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown tbValMin;
        private System.Windows.Forms.NumericUpDown tbValMax;
        private System.Windows.Forms.Button btnReset;
    }
}