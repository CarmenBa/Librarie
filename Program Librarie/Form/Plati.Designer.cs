namespace Program_Librarie
{
    partial class Plati
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
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dgvAchizitii = new System.Windows.Forms.DataGridView();
            this.idAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achizitieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.dgvPlati = new System.Windows.Forms.DataGridView();
            this.idPlataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAchizitieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDocumentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDocumentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNrDoc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.achizitieTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.achizitieTableAdapter();
            this.plataTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.plataTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchizitii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSuma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(291, 197);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(135, 38);
            this.btnStergere.TabIndex = 85;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(152, 197);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(135, 38);
            this.btnModifica.TabIndex = 76;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(13, 197);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(135, 38);
            this.btnAdaugare.TabIndex = 74;
            this.btnAdaugare.Text = "Adaugă";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dgvAchizitii
            // 
            this.dgvAchizitii.AllowUserToAddRows = false;
            this.dgvAchizitii.AllowUserToDeleteRows = false;
            this.dgvAchizitii.AutoGenerateColumns = false;
            this.dgvAchizitii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAchizitii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAchizitieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.furnizorDataGridViewTextBoxColumn,
            this.idFurnizorDataGridViewTextBoxColumn,
            this.serieDocumentDataGridViewTextBoxColumn,
            this.nrDocumentDataGridViewTextBoxColumn});
            this.dgvAchizitii.DataSource = this.achizitieBindingSource;
            this.dgvAchizitii.Location = new System.Drawing.Point(6, 25);
            this.dgvAchizitii.Name = "dgvAchizitii";
            this.dgvAchizitii.ReadOnly = true;
            this.dgvAchizitii.Size = new System.Drawing.Size(633, 122);
            this.dgvAchizitii.TabIndex = 99;
            this.dgvAchizitii.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAchizitii_CellClick);
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
            // furnizorDataGridViewTextBoxColumn
            // 
            this.furnizorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.furnizorDataGridViewTextBoxColumn.DataPropertyName = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn.HeaderText = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn.Name = "furnizorDataGridViewTextBoxColumn";
            this.furnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.furnizorDataGridViewTextBoxColumn.Width = 69;
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
            // achizitieBindingSource
            // 
            this.achizitieBindingSource.DataMember = "achizitie";
            this.achizitieBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPlati
            // 
            this.dgvPlati.AllowUserToAddRows = false;
            this.dgvPlati.AllowUserToDeleteRows = false;
            this.dgvPlati.AutoGenerateColumns = false;
            this.dgvPlati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlataDataGridViewTextBoxColumn,
            this.idAchizitieDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1,
            this.furnizorDataGridViewTextBoxColumn1,
            this.serieDocumentDataGridViewTextBoxColumn1,
            this.nrDocumentDataGridViewTextBoxColumn1,
            this.sumaDataGridViewTextBoxColumn,
            this.idFurnizorDataGridViewTextBoxColumn1});
            this.dgvPlati.DataSource = this.plataBindingSource;
            this.dgvPlati.Location = new System.Drawing.Point(6, 26);
            this.dgvPlati.Name = "dgvPlati";
            this.dgvPlati.ReadOnly = true;
            this.dgvPlati.Size = new System.Drawing.Size(633, 206);
            this.dgvPlati.TabIndex = 100;
            this.dgvPlati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlati_CellClick);
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
            // idAchizitieDataGridViewTextBoxColumn1
            // 
            this.idAchizitieDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idAchizitieDataGridViewTextBoxColumn1.DataPropertyName = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn1.HeaderText = "IdAchizitie";
            this.idAchizitieDataGridViewTextBoxColumn1.Name = "idAchizitieDataGridViewTextBoxColumn1";
            this.idAchizitieDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAchizitieDataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn1.Width = 55;
            // 
            // furnizorDataGridViewTextBoxColumn1
            // 
            this.furnizorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.furnizorDataGridViewTextBoxColumn1.DataPropertyName = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn1.HeaderText = "Furnizor";
            this.furnizorDataGridViewTextBoxColumn1.Name = "furnizorDataGridViewTextBoxColumn1";
            this.furnizorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.furnizorDataGridViewTextBoxColumn1.Width = 69;
            // 
            // serieDocumentDataGridViewTextBoxColumn1
            // 
            this.serieDocumentDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serieDocumentDataGridViewTextBoxColumn1.DataPropertyName = "SerieDocument";
            this.serieDocumentDataGridViewTextBoxColumn1.HeaderText = "SerieDocument";
            this.serieDocumentDataGridViewTextBoxColumn1.Name = "serieDocumentDataGridViewTextBoxColumn1";
            this.serieDocumentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.serieDocumentDataGridViewTextBoxColumn1.Width = 105;
            // 
            // nrDocumentDataGridViewTextBoxColumn1
            // 
            this.nrDocumentDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nrDocumentDataGridViewTextBoxColumn1.DataPropertyName = "NrDocument";
            this.nrDocumentDataGridViewTextBoxColumn1.HeaderText = "NrDocument";
            this.nrDocumentDataGridViewTextBoxColumn1.Name = "nrDocumentDataGridViewTextBoxColumn1";
            this.nrDocumentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nrDocumentDataGridViewTextBoxColumn1.Width = 92;
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
            // idFurnizorDataGridViewTextBoxColumn1
            // 
            this.idFurnizorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idFurnizorDataGridViewTextBoxColumn1.DataPropertyName = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn1.HeaderText = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn1.Name = "idFurnizorDataGridViewTextBoxColumn1";
            this.idFurnizorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idFurnizorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idFurnizorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // plataBindingSource
            // 
            this.plataBindingSource.DataMember = "plata";
            this.plataBindingSource.DataSource = this.librarieDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 87;
            this.label6.Text = "Sumă platită";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Furnizor";
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(152, 41);
            this.cmbFurnizor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(274, 28);
            this.cmbFurnizor.TabIndex = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNrDoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSerie);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Controls.Add(this.dtData);
            this.groupBox2.Controls.Add(this.btnModifica);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSuma);
            this.groupBox2.Controls.Add(this.btnAdaugare);
            this.groupBox2.Controls.Add(this.cmbFurnizor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(672, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(440, 251);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date pentru efectuarea plății";
            // 
            // tbNrDoc
            // 
            this.tbNrDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNrDoc.Location = new System.Drawing.Point(152, 166);
            this.tbNrDoc.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbNrDoc.Name = "tbNrDoc";
            this.tbNrDoc.Size = new System.Drawing.Size(274, 26);
            this.tbNrDoc.TabIndex = 102;
            this.tbNrDoc.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "Nr. Doc.";
            // 
            // tbSerie
            // 
            this.tbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerie.Location = new System.Drawing.Point(152, 137);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(2);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(274, 26);
            this.tbSerie.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 91;
            this.label4.Text = "Serie Doc.";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(152, 106);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(274, 26);
            this.dtData.TabIndex = 90;
            this.dtData.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "Data";
            // 
            // tbSuma
            // 
            this.tbSuma.DecimalPlaces = 2;
            this.tbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSuma.Location = new System.Drawing.Point(152, 74);
            this.tbSuma.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(274, 26);
            this.tbSuma.TabIndex = 88;
            this.tbSuma.ThousandsSeparator = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(19, 433);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 38);
            this.btnReset.TabIndex = 101;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // achizitieTableAdapter
            // 
            this.achizitieTableAdapter.ClearBeforeFill = true;
            // 
            // plataTableAdapter
            // 
            this.plataTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAchizitii);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 157);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achizitii";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPlati);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(13, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 251);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plati";
            // 
            // Plati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1125, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Plati";
            this.Text = "Plati";
            this.Load += new System.EventHandler(this.Plati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchizitii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plataBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSuma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dgvAchizitii;
        private System.Windows.Forms.DataGridView dgvPlati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFurnizor;
        private System.Windows.Forms.GroupBox groupBox2;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbSuma;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown tbNrDoc;
        private System.Windows.Forms.BindingSource achizitieBindingSource;
        private LibrarieDataSetTableAdapters.achizitieTableAdapter achizitieTableAdapter;
        private System.Windows.Forms.BindingSource plataBindingSource;
        private LibrarieDataSetTableAdapters.plataTableAdapter plataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDocumentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}