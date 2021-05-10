namespace Program_Librarie
{
    partial class Vanzari
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
            this.btnCauta = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPerioada = new System.Windows.Forms.RadioButton();
            this.rbTot = new System.Windows.Forms.RadioButton();
            this.dgvVanzari = new System.Windows.Forms.DataGridView();
            this.idVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linievanzareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.linievanzareTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.linievanzareTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.lbActualTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanzari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linievanzareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(560, 24);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(170, 38);
            this.btnCauta.TabIndex = 64;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(93, 27);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(128, 24);
            this.dtFrom.TabIndex = 68;
            this.dtFrom.Value = new System.DateTime(2019, 1, 1, 13, 26, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(303, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(253, 84);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectează perioada dorită";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Până la";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(93, 55);
            this.dtTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(128, 24);
            this.dtTo.TabIndex = 70;
            this.dtTo.Value = new System.DateTime(2020, 1, 1, 13, 29, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Din data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPerioada);
            this.groupBox2.Controls.Add(this.rbTot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(279, 84);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selectează modalitatea de căutare";
            // 
            // rbPerioada
            // 
            this.rbPerioada.AutoSize = true;
            this.rbPerioada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerioada.Location = new System.Drawing.Point(12, 50);
            this.rbPerioada.Margin = new System.Windows.Forms.Padding(2);
            this.rbPerioada.Name = "rbPerioada";
            this.rbPerioada.Size = new System.Drawing.Size(210, 26);
            this.rbPerioada.TabIndex = 2;
            this.rbPerioada.Text = "Selectează perioadă";
            this.rbPerioada.UseVisualStyleBackColor = true;
            // 
            // rbTot
            // 
            this.rbTot.AutoSize = true;
            this.rbTot.Checked = true;
            this.rbTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTot.Location = new System.Drawing.Point(12, 20);
            this.rbTot.Margin = new System.Windows.Forms.Padding(2);
            this.rbTot.Name = "rbTot";
            this.rbTot.Size = new System.Drawing.Size(166, 26);
            this.rbTot.TabIndex = 1;
            this.rbTot.TabStop = true;
            this.rbTot.Text = "Toate vânzările";
            this.rbTot.UseVisualStyleBackColor = true;
            // 
            // dgvVanzari
            // 
            this.dgvVanzari.AllowUserToAddRows = false;
            this.dgvVanzari.AllowUserToDeleteRows = false;
            this.dgvVanzari.AutoGenerateColumns = false;
            this.dgvVanzari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanzari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVanzareDataGridViewTextBoxColumn,
            this.tipProdusDataGridViewTextBoxColumn,
            this.produsDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.idTipProdusDataGridViewTextBoxColumn});
            this.dgvVanzari.DataSource = this.linievanzareBindingSource;
            this.dgvVanzari.Location = new System.Drawing.Point(13, 110);
            this.dgvVanzari.Name = "dgvVanzari";
            this.dgvVanzari.ReadOnly = true;
            this.dgvVanzari.Size = new System.Drawing.Size(934, 418);
            this.dgvVanzari.TabIndex = 71;
            // 
            // idVanzareDataGridViewTextBoxColumn
            // 
            this.idVanzareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idVanzareDataGridViewTextBoxColumn.DataPropertyName = "IdVanzare";
            this.idVanzareDataGridViewTextBoxColumn.HeaderText = "IdVanzare";
            this.idVanzareDataGridViewTextBoxColumn.Name = "idVanzareDataGridViewTextBoxColumn";
            this.idVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVanzareDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipProdusDataGridViewTextBoxColumn
            // 
            this.tipProdusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipProdusDataGridViewTextBoxColumn.DataPropertyName = "TipProdus";
            this.tipProdusDataGridViewTextBoxColumn.HeaderText = "TipProdus";
            this.tipProdusDataGridViewTextBoxColumn.Name = "tipProdusDataGridViewTextBoxColumn";
            this.tipProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipProdusDataGridViewTextBoxColumn.Width = 80;
            // 
            // produsDataGridViewTextBoxColumn
            // 
            this.produsDataGridViewTextBoxColumn.DataPropertyName = "Produs";
            this.produsDataGridViewTextBoxColumn.HeaderText = "Produs";
            this.produsDataGridViewTextBoxColumn.Name = "produsDataGridViewTextBoxColumn";
            this.produsDataGridViewTextBoxColumn.ReadOnly = true;
            this.produsDataGridViewTextBoxColumn.Width = 200;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 74;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 51;
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
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 60;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTipProdusDataGridViewTextBoxColumn
            // 
            this.idTipProdusDataGridViewTextBoxColumn.DataPropertyName = "IdTipProdus";
            this.idTipProdusDataGridViewTextBoxColumn.HeaderText = "IdTipProdus";
            this.idTipProdusDataGridViewTextBoxColumn.Name = "idTipProdusDataGridViewTextBoxColumn";
            this.idTipProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipProdusDataGridViewTextBoxColumn.Visible = false;
            // 
            // linievanzareBindingSource
            // 
            this.linievanzareBindingSource.DataMember = "linievanzare";
            this.linievanzareBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linievanzareTableAdapter
            // 
            this.linievanzareTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 73;
            this.label4.Text = "Total vânzări:";
            // 
            // lbActualTotal
            // 
            this.lbActualTotal.AutoSize = true;
            this.lbActualTotal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActualTotal.Location = new System.Drawing.Point(132, 544);
            this.lbActualTotal.Name = "lbActualTotal";
            this.lbActualTotal.Size = new System.Drawing.Size(0, 23);
            this.lbActualTotal.TabIndex = 74;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(560, 66);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 39);
            this.btnReset.TabIndex = 107;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Vanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(962, 606);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbActualTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvVanzari);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCauta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vanzari";
            this.Text = "Vanzari";
            this.Load += new System.EventHandler(this.Vanzari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanzari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linievanzareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPerioada;
        private System.Windows.Forms.RadioButton rbTot;
        private System.Windows.Forms.DataGridView dgvVanzari;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource linievanzareBindingSource;
        private LibrarieDataSetTableAdapters.linievanzareTableAdapter linievanzareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbActualTotal;
        private System.Windows.Forms.Button btnReset;
    }
}