namespace Program_Librarie
{
    partial class Achizitii
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnProdusStergere = new System.Windows.Forms.Button();
            this.btnProdusModifica = new System.Windows.Forms.Button();
            this.btnProdusAdaugare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLinieAchizitie = new System.Windows.Forms.DataGridView();
            this.idAchizitieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linieachizitieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.tbCantitate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipProdus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProdus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNrDoc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAchizitie = new System.Windows.Forms.DataGridView();
            this.idAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achizitieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAchizitieModifica = new System.Windows.Forms.Button();
            this.btnAchizitieAdaugare = new System.Windows.Forms.Button();
            this.btnAchizitieStergere = new System.Windows.Forms.Button();
            this.achizitieTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.achizitieTableAdapter();
            this.linieachizitieTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.linieachizitieTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinieAchizitie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linieachizitieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchizitie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(20, 445);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 38);
            this.btnReset.TabIndex = 113;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnProdusStergere
            // 
            this.btnProdusStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnProdusStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusStergere.Location = new System.Drawing.Point(955, 168);
            this.btnProdusStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusStergere.Name = "btnProdusStergere";
            this.btnProdusStergere.Size = new System.Drawing.Size(138, 38);
            this.btnProdusStergere.TabIndex = 112;
            this.btnProdusStergere.Text = "Șterge";
            this.btnProdusStergere.UseVisualStyleBackColor = false;
            this.btnProdusStergere.Click += new System.EventHandler(this.btnProdusStergere_Click);
            // 
            // btnProdusModifica
            // 
            this.btnProdusModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProdusModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusModifica.Location = new System.Drawing.Point(813, 168);
            this.btnProdusModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusModifica.Name = "btnProdusModifica";
            this.btnProdusModifica.Size = new System.Drawing.Size(138, 38);
            this.btnProdusModifica.TabIndex = 111;
            this.btnProdusModifica.Text = "Modifică";
            this.btnProdusModifica.UseVisualStyleBackColor = false;
            this.btnProdusModifica.Click += new System.EventHandler(this.btnProdusModifica_Click);
            // 
            // btnProdusAdaugare
            // 
            this.btnProdusAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProdusAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusAdaugare.Location = new System.Drawing.Point(671, 168);
            this.btnProdusAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusAdaugare.Name = "btnProdusAdaugare";
            this.btnProdusAdaugare.Size = new System.Drawing.Size(138, 38);
            this.btnProdusAdaugare.TabIndex = 110;
            this.btnProdusAdaugare.Text = "Adaugă";
            this.btnProdusAdaugare.UseVisualStyleBackColor = false;
            this.btnProdusAdaugare.Click += new System.EventHandler(this.btnProdusAdaugare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLinieAchizitie);
            this.groupBox2.Controls.Add(this.tbCantitate);
            this.groupBox2.Controls.Add(this.btnProdusStergere);
            this.groupBox2.Controls.Add(this.btnProdusModifica);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnProdusAdaugare);
            this.groupBox2.Controls.Add(this.tbPret);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbTipProdus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbProdus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(14, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 222);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produs";
            // 
            // dgvLinieAchizitie
            // 
            this.dgvLinieAchizitie.AllowUserToAddRows = false;
            this.dgvLinieAchizitie.AllowUserToDeleteRows = false;
            this.dgvLinieAchizitie.AutoGenerateColumns = false;
            this.dgvLinieAchizitie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinieAchizitie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAchizitieDataGridViewTextBoxColumn1,
            this.idProdusDataGridViewTextBoxColumn,
            this.idTipProdusDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn1,
            this.tipProdusDataGridViewTextBoxColumn,
            this.numeProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dgvLinieAchizitie.DataSource = this.linieachizitieBindingSource;
            this.dgvLinieAchizitie.Location = new System.Drawing.Point(6, 25);
            this.dgvLinieAchizitie.Name = "dgvLinieAchizitie";
            this.dgvLinieAchizitie.ReadOnly = true;
            this.dgvLinieAchizitie.Size = new System.Drawing.Size(657, 181);
            this.dgvLinieAchizitie.TabIndex = 113;
            this.dgvLinieAchizitie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinieAchizitie_CellClick);
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
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn1.Width = 55;
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
            // numeProdusDataGridViewTextBoxColumn
            // 
            this.numeProdusDataGridViewTextBoxColumn.DataPropertyName = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn.HeaderText = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn.Name = "numeProdusDataGridViewTextBoxColumn";
            this.numeProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeProdusDataGridViewTextBoxColumn.Width = 200;
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
            // linieachizitieBindingSource
            // 
            this.linieachizitieBindingSource.DataMember = "linieachizitie";
            this.linieachizitieBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCantitate.Location = new System.Drawing.Point(810, 121);
            this.tbCantitate.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(283, 26);
            this.tbCantitate.TabIndex = 102;
            this.tbCantitate.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(673, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 101;
            this.label5.Text = "Cantitate";
            // 
            // tbPret
            // 
            this.tbPret.DecimalPlaces = 2;
            this.tbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPret.Location = new System.Drawing.Point(810, 89);
            this.tbPret.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(283, 26);
            this.tbPret.TabIndex = 100;
            this.tbPret.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(673, 89);
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
            this.cmbTipProdus.Location = new System.Drawing.Point(810, 24);
            this.cmbTipProdus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipProdus.Name = "cmbTipProdus";
            this.cmbTipProdus.Size = new System.Drawing.Size(283, 28);
            this.cmbTipProdus.TabIndex = 98;
            this.cmbTipProdus.SelectedIndexChanged += new System.EventHandler(this.cmbTipProdus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 25);
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
            this.cmbProdus.Location = new System.Drawing.Point(810, 56);
            this.cmbProdus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProdus.Name = "cmbProdus";
            this.cmbProdus.Size = new System.Drawing.Size(283, 28);
            this.cmbProdus.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Produs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNrDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSerie);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvAchizitie);
            this.groupBox1.Controls.Add(this.cmbFurnizor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAchizitieModifica);
            this.groupBox1.Controls.Add(this.btnAchizitieAdaugare);
            this.groupBox1.Controls.Add(this.btnAchizitieStergere);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 200);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achizitie";
            // 
            // tbNrDoc
            // 
            this.tbNrDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNrDoc.Location = new System.Drawing.Point(707, 120);
            this.tbNrDoc.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.tbNrDoc.Name = "tbNrDoc";
            this.tbNrDoc.Size = new System.Drawing.Size(265, 26);
            this.tbNrDoc.TabIndex = 112;
            this.tbNrDoc.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 111;
            this.label1.Text = "Nr. Doc.";
            // 
            // tbSerie
            // 
            this.tbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerie.Location = new System.Drawing.Point(707, 89);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(2);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(266, 26);
            this.tbSerie.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 109;
            this.label7.Text = "Serie Doc.";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtData.Location = new System.Drawing.Point(707, 58);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(266, 26);
            this.dtData.TabIndex = 108;
            this.dtData.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 107;
            this.label8.Text = "Data";
            // 
            // dgvAchizitie
            // 
            this.dgvAchizitie.AllowUserToAddRows = false;
            this.dgvAchizitie.AllowUserToDeleteRows = false;
            this.dgvAchizitie.AutoGenerateColumns = false;
            this.dgvAchizitie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAchizitie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAchizitieDataGridViewTextBoxColumn,
            this.idFurnizorDataGridViewTextBoxColumn,
            this.furnizorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.nrDocumentDataGridViewTextBoxColumn,
            this.serieDocumentDataGridViewTextBoxColumn});
            this.dgvAchizitie.DataSource = this.achizitieBindingSource;
            this.dgvAchizitie.Location = new System.Drawing.Point(12, 26);
            this.dgvAchizitie.Name = "dgvAchizitie";
            this.dgvAchizitie.ReadOnly = true;
            this.dgvAchizitie.Size = new System.Drawing.Size(531, 163);
            this.dgvAchizitie.TabIndex = 106;
            this.dgvAchizitie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAchizitie_CellClick);
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
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 55;
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
            // serieDocumentDataGridViewTextBoxColumn
            // 
            this.serieDocumentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serieDocumentDataGridViewTextBoxColumn.DataPropertyName = "SerieDocument";
            this.serieDocumentDataGridViewTextBoxColumn.HeaderText = "SerieDocument";
            this.serieDocumentDataGridViewTextBoxColumn.Name = "serieDocumentDataGridViewTextBoxColumn";
            this.serieDocumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDocumentDataGridViewTextBoxColumn.Width = 105;
            // 
            // achizitieBindingSource
            // 
            this.achizitieBindingSource.DataMember = "achizitie";
            this.achizitieBindingSource.DataSource = this.librarieDataSet;
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(708, 26);
            this.cmbFurnizor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(265, 28);
            this.cmbFurnizor.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Furnizor";
            // 
            // btnAchizitieModifica
            // 
            this.btnAchizitieModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAchizitieModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAchizitieModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchizitieModifica.Location = new System.Drawing.Point(693, 151);
            this.btnAchizitieModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnAchizitieModifica.Name = "btnAchizitieModifica";
            this.btnAchizitieModifica.Size = new System.Drawing.Size(138, 38);
            this.btnAchizitieModifica.TabIndex = 104;
            this.btnAchizitieModifica.Text = "Modifică";
            this.btnAchizitieModifica.UseVisualStyleBackColor = false;
            this.btnAchizitieModifica.Click += new System.EventHandler(this.btnAchizitieModifica_Click);
            // 
            // btnAchizitieAdaugare
            // 
            this.btnAchizitieAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAchizitieAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAchizitieAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchizitieAdaugare.Location = new System.Drawing.Point(551, 151);
            this.btnAchizitieAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAchizitieAdaugare.Name = "btnAchizitieAdaugare";
            this.btnAchizitieAdaugare.Size = new System.Drawing.Size(138, 38);
            this.btnAchizitieAdaugare.TabIndex = 103;
            this.btnAchizitieAdaugare.Text = "Adaugă";
            this.btnAchizitieAdaugare.UseVisualStyleBackColor = false;
            this.btnAchizitieAdaugare.Click += new System.EventHandler(this.btnAchizitieAdaugare_Click);
            // 
            // btnAchizitieStergere
            // 
            this.btnAchizitieStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnAchizitieStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAchizitieStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchizitieStergere.Location = new System.Drawing.Point(835, 151);
            this.btnAchizitieStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnAchizitieStergere.Name = "btnAchizitieStergere";
            this.btnAchizitieStergere.Size = new System.Drawing.Size(138, 38);
            this.btnAchizitieStergere.TabIndex = 105;
            this.btnAchizitieStergere.Text = "Șterge";
            this.btnAchizitieStergere.UseVisualStyleBackColor = false;
            this.btnAchizitieStergere.Click += new System.EventHandler(this.btnAchizitieStergere_Click);
            // 
            // achizitieTableAdapter
            // 
            this.achizitieTableAdapter.ClearBeforeFill = true;
            // 
            // linieachizitieTableAdapter
            // 
            this.linieachizitieTableAdapter.ClearBeforeFill = true;
            // 
            // Achizitii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1172, 499);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Achizitii";
            this.Text = "Achizitii";
            this.Load += new System.EventHandler(this.Achizitii_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinieAchizitie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linieachizitieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchizitie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnProdusStergere;
        private System.Windows.Forms.Button btnProdusModifica;
        private System.Windows.Forms.Button btnProdusAdaugare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLinieAchizitie;
        private System.Windows.Forms.NumericUpDown tbCantitate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tbPret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipProdus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProdus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAchizitie;
        private System.Windows.Forms.ComboBox cmbFurnizor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAchizitieModifica;
        private System.Windows.Forms.Button btnAchizitieAdaugare;
        private System.Windows.Forms.Button btnAchizitieStergere;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource achizitieBindingSource;
        private LibrarieDataSetTableAdapters.achizitieTableAdapter achizitieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource linieachizitieBindingSource;
        private LibrarieDataSetTableAdapters.linieachizitieTableAdapter linieachizitieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAchizitieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown tbNrDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
    }
}