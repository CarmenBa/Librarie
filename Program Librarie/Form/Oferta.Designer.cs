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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginăPrincipalăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edituriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.echipamenteDeBiroticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cliențiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vânzăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solduriFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLinieOferta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCantitate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipProdus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProdus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOferta = new System.Windows.Forms.DataGridView();
            this.btnProdusStergere = new System.Windows.Forms.Button();
            this.btnProdusModifica = new System.Windows.Forms.Button();
            this.btnProdusAdaugare = new System.Windows.Forms.Button();
            this.idOfertaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.linieofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofertaTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.ofertaTableAdapter();
            this.linieofertaTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.linieofertaTableAdapter();
            this.idOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinieOferta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linieofertaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOfertaModifica
            // 
            this.btnOfertaModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOfertaModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOfertaModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfertaModifica.Location = new System.Drawing.Point(710, 138);
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
            this.btnOfertaAdaugare.Location = new System.Drawing.Point(568, 138);
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
            this.btnOfertaStergere.Location = new System.Drawing.Point(852, 138);
            this.btnOfertaStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnOfertaStergere.Name = "btnOfertaStergere";
            this.btnOfertaStergere.Size = new System.Drawing.Size(138, 38);
            this.btnOfertaStergere.TabIndex = 50;
            this.btnOfertaStergere.Text = "Șterge";
            this.btnOfertaStergere.UseVisualStyleBackColor = false;
            this.btnOfertaStergere.Click += new System.EventHandler(this.btnOfertaStergere_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginăPrincipalăToolStripMenuItem,
            this.adaugăToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginăPrincipalăToolStripMenuItem
            // 
            this.paginăPrincipalăToolStripMenuItem.Name = "paginăPrincipalăToolStripMenuItem";
            this.paginăPrincipalăToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.paginăPrincipalăToolStripMenuItem.Text = "Acasă";
            // 
            // adaugăToolStripMenuItem
            // 
            this.adaugăToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cărțiToolStripMenuItem,
            this.echipamenteDeBiroticaToolStripMenuItem,
            this.cliențiToolStripMenuItem,
            this.furnizoriToolStripMenuItem});
            this.adaugăToolStripMenuItem.Name = "adaugăToolStripMenuItem";
            this.adaugăToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.adaugăToolStripMenuItem.Text = "Adaugă";
            // 
            // cărțiToolStripMenuItem
            // 
            this.cărțiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoriToolStripMenuItem,
            this.edituriToolStripMenuItem,
            this.cărțiToolStripMenuItem1});
            this.cărțiToolStripMenuItem.Name = "cărțiToolStripMenuItem";
            this.cărțiToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cărțiToolStripMenuItem.Text = "Cărți și despre cărți";
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.autoriToolStripMenuItem.Text = "Autori";
            // 
            // edituriToolStripMenuItem
            // 
            this.edituriToolStripMenuItem.Name = "edituriToolStripMenuItem";
            this.edituriToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.edituriToolStripMenuItem.Text = "Edituri";
            // 
            // cărțiToolStripMenuItem1
            // 
            this.cărțiToolStripMenuItem1.Name = "cărțiToolStripMenuItem1";
            this.cărțiToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.cărțiToolStripMenuItem1.Text = "Cărți";
            // 
            // echipamenteDeBiroticaToolStripMenuItem
            // 
            this.echipamenteDeBiroticaToolStripMenuItem.Name = "echipamenteDeBiroticaToolStripMenuItem";
            this.echipamenteDeBiroticaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.echipamenteDeBiroticaToolStripMenuItem.Text = "Echipamente de birotica";
            // 
            // cliențiToolStripMenuItem
            // 
            this.cliențiToolStripMenuItem.Name = "cliențiToolStripMenuItem";
            this.cliențiToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cliențiToolStripMenuItem.Text = "Clienți";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vânzăriToolStripMenuItem,
            this.stocuriToolStripMenuItem,
            this.solduriFurnizoriToolStripMenuItem,
            this.cărțiToolStripMenuItem2});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // vânzăriToolStripMenuItem
            // 
            this.vânzăriToolStripMenuItem.Name = "vânzăriToolStripMenuItem";
            this.vânzăriToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.vânzăriToolStripMenuItem.Text = "Vânzări";
            // 
            // stocuriToolStripMenuItem
            // 
            this.stocuriToolStripMenuItem.Name = "stocuriToolStripMenuItem";
            this.stocuriToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.stocuriToolStripMenuItem.Text = "Stocuri";
            // 
            // solduriFurnizoriToolStripMenuItem
            // 
            this.solduriFurnizoriToolStripMenuItem.Name = "solduriFurnizoriToolStripMenuItem";
            this.solduriFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.solduriFurnizoriToolStripMenuItem.Text = "Solduri Furnizori";
            // 
            // cărțiToolStripMenuItem2
            // 
            this.cărțiToolStripMenuItem2.Name = "cărțiToolStripMenuItem2";
            this.cărțiToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.cărțiToolStripMenuItem2.Text = "Produse";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
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
            this.dgvLinieOferta.Location = new System.Drawing.Point(12, 207);
            this.dgvLinieOferta.Name = "dgvLinieOferta";
            this.dgvLinieOferta.ReadOnly = true;
            this.dgvLinieOferta.Size = new System.Drawing.Size(713, 220);
            this.dgvLinieOferta.TabIndex = 52;
            this.dgvLinieOferta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinieOferta_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFurnizor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtDataExpirare);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(570, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 106);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oferta";
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(150, 24);
            this.cmbFurnizor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(265, 28);
            this.cmbFurnizor.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Furnizor";
            // 
            // dtDataExpirare
            // 
            this.dtDataExpirare.Location = new System.Drawing.Point(150, 57);
            this.dtDataExpirare.Name = "dtDataExpirare";
            this.dtDataExpirare.Size = new System.Drawing.Size(265, 26);
            this.dtDataExpirare.TabIndex = 92;
            this.dtDataExpirare.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Data Expirare";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCantitate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPret);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbTipProdus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbProdus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(742, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 165);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produs";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCantitate.Location = new System.Drawing.Point(142, 127);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 127);
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
            this.tbPret.Location = new System.Drawing.Point(142, 95);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 95);
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
            this.cmbTipProdus.Location = new System.Drawing.Point(142, 30);
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
            this.label4.Location = new System.Drawing.Point(5, 31);
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
            this.cmbProdus.Location = new System.Drawing.Point(142, 62);
            this.cmbProdus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProdus.Name = "cmbProdus";
            this.cmbProdus.Size = new System.Drawing.Size(265, 28);
            this.cmbProdus.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Produs";
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
            this.dgvOferta.Location = new System.Drawing.Point(12, 27);
            this.dgvOferta.Name = "dgvOferta";
            this.dgvOferta.ReadOnly = true;
            this.dgvOferta.Size = new System.Drawing.Size(531, 149);
            this.dgvOferta.TabIndex = 55;
            this.dgvOferta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOferta_CellClick);
            // 
            // btnProdusStergere
            // 
            this.btnProdusStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnProdusStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusStergere.Location = new System.Drawing.Point(1026, 389);
            this.btnProdusStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusStergere.Name = "btnProdusStergere";
            this.btnProdusStergere.Size = new System.Drawing.Size(138, 38);
            this.btnProdusStergere.TabIndex = 58;
            this.btnProdusStergere.Text = "Șterge";
            this.btnProdusStergere.UseVisualStyleBackColor = false;
            this.btnProdusStergere.Click += new System.EventHandler(this.btnProdusStergere_Click);
            // 
            // btnProdusModifica
            // 
            this.btnProdusModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProdusModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusModifica.Location = new System.Drawing.Point(884, 389);
            this.btnProdusModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusModifica.Name = "btnProdusModifica";
            this.btnProdusModifica.Size = new System.Drawing.Size(138, 38);
            this.btnProdusModifica.TabIndex = 57;
            this.btnProdusModifica.Text = "Modifică";
            this.btnProdusModifica.UseVisualStyleBackColor = false;
            this.btnProdusModifica.Click += new System.EventHandler(this.btnProdusModifica_Click);
            // 
            // btnProdusAdaugare
            // 
            this.btnProdusAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProdusAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdusAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdusAdaugare.Location = new System.Drawing.Point(742, 389);
            this.btnProdusAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdusAdaugare.Name = "btnProdusAdaugare";
            this.btnProdusAdaugare.Size = new System.Drawing.Size(138, 38);
            this.btnProdusAdaugare.TabIndex = 56;
            this.btnProdusAdaugare.Text = "Adaugă";
            this.btnProdusAdaugare.UseVisualStyleBackColor = false;
            this.btnProdusAdaugare.Click += new System.EventHandler(this.btnProdusAdaugare_Click);
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
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linieofertaBindingSource
            // 
            this.linieofertaBindingSource.DataMember = "linieoferta";
            this.linieofertaBindingSource.DataSource = this.librarieDataSet;
            // 
            // ofertaTableAdapter
            // 
            this.ofertaTableAdapter.ClearBeforeFill = true;
            // 
            // linieofertaTableAdapter
            // 
            this.linieofertaTableAdapter.ClearBeforeFill = true;
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
            this.idProdusDataGridViewTextBoxColumn.Width = 74;
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 436);
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
            this.ClientSize = new System.Drawing.Size(1178, 485);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProdusStergere);
            this.Controls.Add(this.btnProdusModifica);
            this.Controls.Add(this.btnProdusAdaugare);
            this.Controls.Add(this.dgvOferta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLinieOferta);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOfertaStergere);
            this.Controls.Add(this.btnOfertaModifica);
            this.Controls.Add(this.btnOfertaAdaugare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Oferta";
            this.Text = "Oferta";
            this.Load += new System.EventHandler(this.Oferta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinieOferta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linieofertaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOfertaModifica;
        private System.Windows.Forms.Button btnOfertaAdaugare;
        private System.Windows.Forms.Button btnOfertaStergere;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginăPrincipalăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edituriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem echipamenteDeBiroticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cliențiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vânzăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solduriFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
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