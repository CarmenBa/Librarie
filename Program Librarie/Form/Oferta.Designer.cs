namespace Program_Librarie
{
    partial class Oferta
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
            this.btnOfertaModifica = new System.Windows.Forms.Button();
            this.btnOfertaAdaugare = new System.Windows.Forms.Button();
            this.btnOfertaStergere = new System.Windows.Forms.Button();
            this.dgvLinieOferta = new System.Windows.Forms.DataGridView();
            this.idOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linieofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOferta = new System.Windows.Forms.DataGridView();
            this.idOfertaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCantitate = new System.Windows.Forms.NumericUpDown();
            this.btnProdusStergere = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProdusModifica = new System.Windows.Forms.Button();
            this.tbPret = new System.Windows.Forms.NumericUpDown();
            this.btnProdusAdaugare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipProdus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProdus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofertaTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.ofertaTableAdapter();
            this.linieofertaTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.linieofertaTableAdapter();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinieOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linieofertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOfertaModifica
            // 
            this.btnOfertaModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOfertaModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOfertaModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertaModifica.Location = new System.Drawing.Point(684, 136);
            this.btnOfertaModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnOfertaModifica.Name = "btnOfertaModifica";
            this.btnOfertaModifica.Size = new System.Drawing.Size(138, 38);
            this.btnOfertaModifica.TabIndex = 40;
            this.btnOfertaModifica.Text = "Modifică";
            this.btnOfertaModifica.UseVisualStyleBackColor = false;
            this.btnOfertaModifica.Click += new System.EventHandler(this.btnOfertaModifica_Click);
            // 
            // btnOfertaAdaugare
            // 
            this.btnOfertaAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOfertaAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOfertaAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertaAdaugare.Location = new System.Drawing.Point(542, 136);
            this.btnOfertaAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnOfertaAdaugare.Name = "btnOfertaAdaugare";
            this.btnOfertaAdaugare.Size = new System.Drawing.Size(138, 38);
            this.btnOfertaAdaugare.TabIndex = 38;
            this.btnOfertaAdaugare.Text = "Adaugă";
            this.btnOfertaAdaugare.UseVisualStyleBackColor = false;
            this.btnOfertaAdaugare.Click += new System.EventHandler(this.btnOfertaAdaugare_Click);
            // 
            // btnOfertaStergere
            // 
            this.btnOfertaStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnOfertaStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOfertaStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertaStergere.Location = new System.Drawing.Point(826, 136);
            this.btnOfertaStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnOfertaStergere.Name = "btnOfertaStergere";
            this.btnOfertaStergere.Size = new System.Drawing.Size(138, 38);
            this.btnOfertaStergere.TabIndex = 50;
            this.btnOfertaStergere.Text = "Șterge";
            this.btnOfertaStergere.UseVisualStyleBackColor = false;
            this.btnOfertaStergere.Click += new System.EventHandler(this.btnOfertaStergere_Click);
            // 
            // dgvLinieOferta
            // 
            this.dgvLinieOferta.AllowUserToAddRows = false;
            this.dgvLinieOferta.AllowUserToDeleteRows = false;
            this.dgvLinieOferta.AutoGenerateColumns = false;
            this.dgvLinieOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinieOferta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOfertaDataGridViewTextBoxColumn,
            this.IdTipProdus,
            this.TipProdus,
            this.idProdusDataGridViewTextBoxColumn,
            this.numeProdusDataGridViewTextBoxColumn,
            this.pretFurnizorDataGridViewTextBoxColumn,
            this.cantitateOfertaDataGridViewTextBoxColumn,
            this.dataExpirareDataGridViewTextBoxColumn});
            this.dgvLinieOferta.DataSource = this.linieofertaBindingSource;
            this.dgvLinieOferta.Location = new System.Drawing.Point(6, 25);
            this.dgvLinieOferta.Name = "dgvLinieOferta";
            this.dgvLinieOferta.ReadOnly = true;
            this.dgvLinieOferta.Size = new System.Drawing.Size(713, 220);
            this.dgvLinieOferta.TabIndex = 52;
            this.dgvLinieOferta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinieOferta_CellClick);
            // 
            // idOfertaDataGridViewTextBoxColumn
            // 
            this.idOfertaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idOfertaDataGridViewTextBoxColumn.DataPropertyName = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn.HeaderText = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn.Name = "idOfertaDataGridViewTextBoxColumn";
            this.idOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOfertaDataGridViewTextBoxColumn.Width = 70;
            // 
            // IdTipProdus
            // 
            this.IdTipProdus.DataPropertyName = "IdTipProdus";
            this.IdTipProdus.HeaderText = "IdTipProdus";
            this.IdTipProdus.Name = "IdTipProdus";
            this.IdTipProdus.ReadOnly = true;
            this.IdTipProdus.Visible = false;
            // 
            // TipProdus
            // 
            this.TipProdus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipProdus.DataPropertyName = "TipProdus";
            this.TipProdus.HeaderText = "TipProdus";
            this.TipProdus.Name = "TipProdus";
            this.TipProdus.ReadOnly = true;
            this.TipProdus.Width = 80;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeProdusDataGridViewTextBoxColumn
            // 
            this.numeProdusDataGridViewTextBoxColumn.DataPropertyName = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn.HeaderText = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn.Name = "numeProdusDataGridViewTextBoxColumn";
            this.numeProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeProdusDataGridViewTextBoxColumn.Width = 200;
            // 
            // pretFurnizorDataGridViewTextBoxColumn
            // 
            this.pretFurnizorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pretFurnizorDataGridViewTextBoxColumn.DataPropertyName = "PretFurnizor";
            this.pretFurnizorDataGridViewTextBoxColumn.HeaderText = "PretFurnizor";
            this.pretFurnizorDataGridViewTextBoxColumn.Name = "pretFurnizorDataGridViewTextBoxColumn";
            this.pretFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretFurnizorDataGridViewTextBoxColumn.Width = 88;
            // 
            // cantitateOfertaDataGridViewTextBoxColumn
            // 
            this.cantitateOfertaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantitateOfertaDataGridViewTextBoxColumn.DataPropertyName = "CantitateOferta";
            this.cantitateOfertaDataGridViewTextBoxColumn.HeaderText = "CantitateOferta";
            this.cantitateOfertaDataGridViewTextBoxColumn.Name = "cantitateOfertaDataGridViewTextBoxColumn";
            this.cantitateOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateOfertaDataGridViewTextBoxColumn.Width = 103;
            // 
            // dataExpirareDataGridViewTextBoxColumn
            // 
            this.dataExpirareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataExpirareDataGridViewTextBoxColumn.DataPropertyName = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn.HeaderText = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn.Name = "dataExpirareDataGridViewTextBoxColumn";
            this.dataExpirareDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataExpirareDataGridViewTextBoxColumn.Width = 93;
            // 
            // linieofertaBindingSource
            // 
            this.linieofertaBindingSource.DataMember = "linieoferta";
            this.linieofertaBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFurnizor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtDataExpirare);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvOferta);
            this.groupBox1.Controls.Add(this.btnOfertaStergere);
            this.groupBox1.Controls.Add(this.btnOfertaAdaugare);
            this.groupBox1.Controls.Add(this.btnOfertaModifica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 192);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oferta";
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(684, 25);
            this.cmbFurnizor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(280, 28);
            this.cmbFurnizor.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Furnizor";
            // 
            // dtDataExpirare
            // 
            this.dtDataExpirare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDataExpirare.Location = new System.Drawing.Point(684, 58);
            this.dtDataExpirare.Name = "dtDataExpirare";
            this.dtDataExpirare.Size = new System.Drawing.Size(280, 26);
            this.dtDataExpirare.TabIndex = 92;
            this.dtDataExpirare.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Data Expirare";
            // 
            // dgvOferta
            // 
            this.dgvOferta.AllowUserToAddRows = false;
            this.dgvOferta.AllowUserToDeleteRows = false;
            this.dgvOferta.AutoGenerateColumns = false;
            this.dgvOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOferta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOfertaDataGridViewTextBoxColumn1,
            this.idFurnizorDataGridViewTextBoxColumn,
            this.furnizorDataGridViewTextBoxColumn,
            this.dataExpirareDataGridViewTextBoxColumn1});
            this.dgvOferta.DataSource = this.ofertaBindingSource;
            this.dgvOferta.Location = new System.Drawing.Point(6, 25);
            this.dgvOferta.Name = "dgvOferta";
            this.dgvOferta.ReadOnly = true;
            this.dgvOferta.Size = new System.Drawing.Size(531, 149);
            this.dgvOferta.TabIndex = 55;
            this.dgvOferta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOferta_CellClick);
            // 
            // idOfertaDataGridViewTextBoxColumn1
            // 
            this.idOfertaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idOfertaDataGridViewTextBoxColumn1.DataPropertyName = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn1.HeaderText = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn1.Name = "idOfertaDataGridViewTextBoxColumn1";
            this.idOfertaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idOfertaDataGridViewTextBoxColumn1.Width = 70;
            // 
            // idFurnizorDataGridViewTextBoxColumn
            // 
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
            // dataExpirareDataGridViewTextBoxColumn1
            // 
            this.dataExpirareDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataExpirareDataGridViewTextBoxColumn1.DataPropertyName = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn1.HeaderText = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn1.Name = "dataExpirareDataGridViewTextBoxColumn1";
            this.dataExpirareDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataExpirareDataGridViewTextBoxColumn1.Width = 93;
            // 
            // ofertaBindingSource
            // 
            this.ofertaBindingSource.DataMember = "oferta";
            this.ofertaBindingSource.DataSource = this.librarieDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCantitate);
            this.groupBox2.Controls.Add(this.btnProdusStergere);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnProdusModifica);
            this.groupBox2.Controls.Add(this.tbPret);
            this.groupBox2.Controls.Add(this.btnProdusAdaugare);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbTipProdus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvLinieOferta);
            this.groupBox2.Controls.Add(this.cmbProdus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1162, 263);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produs";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCantitate.Location = new System.Drawing.Point(881, 122);
            this.tbCantitate.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(265, 26);
            this.tbCantitate.TabIndex = 102;
            this.tbCantitate.ThousandsSeparator = true;
            // 
            // btnProdusStergere
            // 
            this.btnProdusStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnProdusStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusStergere.Location = new System.Drawing.Point(1008, 207);
            this.btnProdusStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusStergere.Name = "btnProdusStergere";
            this.btnProdusStergere.Size = new System.Drawing.Size(138, 38);
            this.btnProdusStergere.TabIndex = 58;
            this.btnProdusStergere.Text = "Șterge";
            this.btnProdusStergere.UseVisualStyleBackColor = false;
            this.btnProdusStergere.Click += new System.EventHandler(this.btnProdusStergere_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(744, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 101;
            this.label5.Text = "Cantitate";
            // 
            // btnProdusModifica
            // 
            this.btnProdusModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProdusModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusModifica.Location = new System.Drawing.Point(866, 207);
            this.btnProdusModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusModifica.Name = "btnProdusModifica";
            this.btnProdusModifica.Size = new System.Drawing.Size(138, 38);
            this.btnProdusModifica.TabIndex = 57;
            this.btnProdusModifica.Text = "Modifică";
            this.btnProdusModifica.UseVisualStyleBackColor = false;
            this.btnProdusModifica.Click += new System.EventHandler(this.btnProdusModifica_Click);
            // 
            // tbPret
            // 
            this.tbPret.DecimalPlaces = 2;
            this.tbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPret.Location = new System.Drawing.Point(881, 90);
            this.tbPret.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(265, 26);
            this.tbPret.TabIndex = 100;
            this.tbPret.ThousandsSeparator = true;
            // 
            // btnProdusAdaugare
            // 
            this.btnProdusAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProdusAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusAdaugare.Location = new System.Drawing.Point(724, 207);
            this.btnProdusAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusAdaugare.Name = "btnProdusAdaugare";
            this.btnProdusAdaugare.Size = new System.Drawing.Size(138, 38);
            this.btnProdusAdaugare.TabIndex = 56;
            this.btnProdusAdaugare.Text = "Adaugă";
            this.btnProdusAdaugare.UseVisualStyleBackColor = false;
            this.btnProdusAdaugare.Click += new System.EventHandler(this.btnProdusAdaugare_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(744, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 99;
            this.label6.Text = "Pret";
            // 
            // cmbTipProdus
            // 
            this.cmbTipProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipProdus.FormattingEnabled = true;
            this.cmbTipProdus.Location = new System.Drawing.Point(881, 25);
            this.cmbTipProdus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipProdus.Name = "cmbTipProdus";
            this.cmbTipProdus.Size = new System.Drawing.Size(265, 28);
            this.cmbTipProdus.TabIndex = 98;
            this.cmbTipProdus.SelectedIndexChanged += new System.EventHandler(this.cmbTipProdus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(744, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 97;
            this.label4.Text = "Tip Produs";
            // 
            // cmbProdus
            // 
            this.cmbProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdus.FormattingEnabled = true;
            this.cmbProdus.Location = new System.Drawing.Point(881, 57);
            this.cmbProdus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProdus.Name = "cmbProdus";
            this.cmbProdus.Size = new System.Drawing.Size(265, 28);
            this.cmbProdus.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Produs";
            // 
            // ofertaTableAdapter
            // 
            this.ofertaTableAdapter.ClearBeforeFill = true;
            // 
            // linieofertaTableAdapter
            // 
            this.linieofertaTableAdapter.ClearBeforeFill = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(18, 478);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 38);
            this.btnReset.TabIndex = 102;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1193, 528);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Oferta";
            this.Text = "Oferta";
            this.Load += new System.EventHandler(this.Oferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinieOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linieofertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOfertaModifica;
        private System.Windows.Forms.Button btnOfertaAdaugare;
        private System.Windows.Forms.Button btnOfertaStergere;
        private System.Windows.Forms.DataGridView dgvLinieOferta;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource ofertaBindingSource;
        private LibrarieDataSetTableAdapters.ofertaTableAdapter ofertaTableAdapter;
        private System.Windows.Forms.BindingSource linieofertaBindingSource;
        private LibrarieDataSetTableAdapters.linieofertaTableAdapter linieofertaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DateTimePicker dtDataExpirare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFurnizor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipProdus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProdus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbPret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tbCantitate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProdusStergere;
        private System.Windows.Forms.Button btnProdusModifica;
        private System.Windows.Forms.Button btnProdusAdaugare;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReset;
    }
}