namespace Program_Librarie
{
    partial class Produse
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
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.lblDomeniu = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblEditura = new System.Windows.Forms.Label();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.cmbDomeniu = new System.Windows.Forms.ComboBox();
            this.cmbEditura = new System.Windows.Forms.ComboBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginăPrincipalăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edituriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cliențiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vânzăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solduriFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cărțiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.lblProdus = new System.Windows.Forms.Label();
            this.cmbTipProdus = new System.Windows.Forms.ComboBox();
            this.cartedetaliuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.tableAdapterManager = new Program_Librarie.LibrarieDataSetTableAdapters.TableAdapterManager();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPaginiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domeniuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edituraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartedetaliuTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.cartedetaliuTableAdapter();
            this.lbAn = new System.Windows.Forms.Label();
            this.lbNrPagini = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.NumericUpDown();
            this.tbCantitate = new System.Windows.Forms.NumericUpDown();
            this.tbAn = new System.Windows.Forms.NumericUpDown();
            this.tbNrPagini = new System.Windows.Forms.NumericUpDown();
            this.furnizorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnizorTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.furnizorTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartedetaliuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrPagini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(1015, 313);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(1016, 66);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(50, 24);
            this.lblTitlu.TabIndex = 4;
            this.lblTitlu.Text = "Titlu";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(1016, 190);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(56, 24);
            this.lblISBN.TabIndex = 5;
            this.lblISBN.Text = "ISBN";
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriere.Location = new System.Drawing.Point(1015, 97);
            this.lblDescriere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(100, 24);
            this.lblDescriere.TabIndex = 6;
            this.lblDescriere.Text = "Descriere";
            // 
            // lblDomeniu
            // 
            this.lblDomeniu.AutoSize = true;
            this.lblDomeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomeniu.Location = new System.Drawing.Point(1015, 345);
            this.lblDomeniu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomeniu.Name = "lblDomeniu";
            this.lblDomeniu.Size = new System.Drawing.Size(94, 24);
            this.lblDomeniu.TabIndex = 7;
            this.lblDomeniu.Text = "Domeniu";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatie.Location = new System.Drawing.Point(1016, 285);
            this.lblLocatie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(77, 24);
            this.lblLocatie.TabIndex = 8;
            this.lblLocatie.Text = "Locatie";
            // 
            // lblEditura
            // 
            this.lblEditura.AutoSize = true;
            this.lblEditura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditura.Location = new System.Drawing.Point(1016, 377);
            this.lblEditura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditura.Name = "lblEditura";
            this.lblEditura.Size = new System.Drawing.Size(76, 24);
            this.lblEditura.TabIndex = 9;
            this.lblEditura.Text = "Editura";
            // 
            // cmbAutor
            // 
            this.cmbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(1160, 313);
            this.cmbAutor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(219, 28);
            this.cmbAutor.TabIndex = 12;
            // 
            // cmbDomeniu
            // 
            this.cmbDomeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDomeniu.FormattingEnabled = true;
            this.cmbDomeniu.Location = new System.Drawing.Point(1160, 345);
            this.cmbDomeniu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDomeniu.Name = "cmbDomeniu";
            this.cmbDomeniu.Size = new System.Drawing.Size(219, 28);
            this.cmbDomeniu.TabIndex = 16;
            // 
            // cmbEditura
            // 
            this.cmbEditura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditura.FormattingEnabled = true;
            this.cmbEditura.Location = new System.Drawing.Point(1160, 377);
            this.cmbEditura.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEditura.Name = "cmbEditura";
            this.cmbEditura.Size = new System.Drawing.Size(219, 28);
            this.cmbEditura.TabIndex = 18;
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(1160, 189);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(2);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(219, 26);
            this.tbISBN.TabIndex = 20;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocatie.Location = new System.Drawing.Point(1160, 283);
            this.tbLocatie.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(219, 26);
            this.tbLocatie.TabIndex = 22;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(1019, 481);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(170, 38);
            this.btnModifica.TabIndex = 25;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btnRenuntare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.Location = new System.Drawing.Point(1209, 481);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(170, 38);
            this.btnRenuntare.TabIndex = 24;
            this.btnRenuntare.Text = "Renunță";
            this.btnRenuntare.UseVisualStyleBackColor = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(1019, 426);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(170, 38);
            this.btnAdaugare.TabIndex = 23;
            this.btnAdaugare.Text = "Adaugă";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(1209, 426);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(170, 38);
            this.btnStergere.TabIndex = 50;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // tbDescriere
            // 
            this.tbDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriere.Location = new System.Drawing.Point(1160, 95);
            this.tbDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(219, 26);
            this.tbDescriere.TabIndex = 51;
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
            this.menuStrip1.Size = new System.Drawing.Size(1411, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "generalMenu";
            // 
            // paginăPrincipalăToolStripMenuItem
            // 
            this.paginăPrincipalăToolStripMenuItem.Name = "paginăPrincipalăToolStripMenuItem";
            this.paginăPrincipalăToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.paginăPrincipalăToolStripMenuItem.Text = "Acasă";
            this.paginăPrincipalăToolStripMenuItem.Click += new System.EventHandler(this.paginăPrincipalăToolStripMenuItem_Click);
            // 
            // adaugăToolStripMenuItem
            // 
            this.adaugăToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cărțiToolStripMenuItem,
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
            this.cărțiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // cliențiToolStripMenuItem
            // 
            this.cliențiToolStripMenuItem.Name = "cliențiToolStripMenuItem";
            this.cliențiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cliențiToolStripMenuItem.Text = "Clienți";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // tbTitlu
            // 
            this.tbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitlu.Location = new System.Drawing.Point(1160, 65);
            this.tbTitlu.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(219, 26);
            this.tbTitlu.TabIndex = 53;
            // 
            // lblProdus
            // 
            this.lblProdus.AutoSize = true;
            this.lblProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdus.Location = new System.Drawing.Point(1016, 34);
            this.lblProdus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(112, 24);
            this.lblProdus.TabIndex = 55;
            this.lblProdus.Text = "Tip Produs";
            // 
            // cmbTipProdus
            // 
            this.cmbTipProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipProdus.FormattingEnabled = true;
            this.cmbTipProdus.Location = new System.Drawing.Point(1160, 33);
            this.cmbTipProdus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipProdus.Name = "cmbTipProdus";
            this.cmbTipProdus.Size = new System.Drawing.Size(219, 28);
            this.cmbTipProdus.TabIndex = 56;
            // 
            // cartedetaliuBindingSource
            // 
            this.cartedetaliuBindingSource.DataMember = "cartedetaliu";
            this.cartedetaliuBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.biroticaTableAdapter = null;
            this.tableAdapterManager.carteTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.domeniuTableAdapter = null;
            this.tableAdapterManager.edituraTableAdapter = null;
            this.tableAdapterManager.furnizorTableAdapter = null;
            this.tableAdapterManager.linievanzareTableAdapter = null;
            this.tableAdapterManager.produsTableAdapter = null;
            this.tableAdapterManager.tipprodusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Program_Librarie.LibrarieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilizatorTableAdapter = null;
            this.tableAdapterManager.vanzariTableAdapter = null;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(1015, 128);
            this.lblPret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(47, 24);
            this.lblPret.TabIndex = 57;
            this.lblPret.Text = "Pret";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(1015, 157);
            this.lblCantitate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(90, 24);
            this.lblCantitate.TabIndex = 59;
            this.lblCantitate.Text = "Cantitate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.produsDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.anDataGridViewTextBoxColumn,
            this.nrPaginiDataGridViewTextBoxColumn,
            this.locatieDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.domeniuDataGridViewTextBoxColumn,
            this.edituraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartedetaliuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(986, 467);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // produsDataGridViewTextBoxColumn
            // 
            this.produsDataGridViewTextBoxColumn.DataPropertyName = "Produs";
            this.produsDataGridViewTextBoxColumn.HeaderText = "Produs";
            this.produsDataGridViewTextBoxColumn.Name = "produsDataGridViewTextBoxColumn";
            this.produsDataGridViewTextBoxColumn.ReadOnly = true;
            this.produsDataGridViewTextBoxColumn.Width = 50;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 30;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 50;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anDataGridViewTextBoxColumn
            // 
            this.anDataGridViewTextBoxColumn.DataPropertyName = "An";
            this.anDataGridViewTextBoxColumn.HeaderText = "An";
            this.anDataGridViewTextBoxColumn.Name = "anDataGridViewTextBoxColumn";
            this.anDataGridViewTextBoxColumn.ReadOnly = true;
            this.anDataGridViewTextBoxColumn.Width = 30;
            // 
            // nrPaginiDataGridViewTextBoxColumn
            // 
            this.nrPaginiDataGridViewTextBoxColumn.DataPropertyName = "NrPagini";
            this.nrPaginiDataGridViewTextBoxColumn.HeaderText = "NrPagini";
            this.nrPaginiDataGridViewTextBoxColumn.Name = "nrPaginiDataGridViewTextBoxColumn";
            this.nrPaginiDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrPaginiDataGridViewTextBoxColumn.Width = 55;
            // 
            // locatieDataGridViewTextBoxColumn
            // 
            this.locatieDataGridViewTextBoxColumn.DataPropertyName = "Locatie";
            this.locatieDataGridViewTextBoxColumn.HeaderText = "Locatie";
            this.locatieDataGridViewTextBoxColumn.Name = "locatieDataGridViewTextBoxColumn";
            this.locatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.locatieDataGridViewTextBoxColumn.Width = 50;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domeniuDataGridViewTextBoxColumn
            // 
            this.domeniuDataGridViewTextBoxColumn.DataPropertyName = "Domeniu";
            this.domeniuDataGridViewTextBoxColumn.HeaderText = "Domeniu";
            this.domeniuDataGridViewTextBoxColumn.Name = "domeniuDataGridViewTextBoxColumn";
            this.domeniuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edituraDataGridViewTextBoxColumn
            // 
            this.edituraDataGridViewTextBoxColumn.DataPropertyName = "Editura";
            this.edituraDataGridViewTextBoxColumn.HeaderText = "Editura";
            this.edituraDataGridViewTextBoxColumn.Name = "edituraDataGridViewTextBoxColumn";
            this.edituraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartedetaliuTableAdapter
            // 
            this.cartedetaliuTableAdapter.ClearBeforeFill = true;
            // 
            // lbAn
            // 
            this.lbAn.AutoSize = true;
            this.lbAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAn.Location = new System.Drawing.Point(1016, 218);
            this.lbAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAn.Name = "lbAn";
            this.lbAn.Size = new System.Drawing.Size(36, 24);
            this.lbAn.TabIndex = 64;
            this.lbAn.Text = "An";
            // 
            // lbNrPagini
            // 
            this.lbNrPagini.AutoSize = true;
            this.lbNrPagini.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrPagini.Location = new System.Drawing.Point(1016, 249);
            this.lbNrPagini.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNrPagini.Name = "lbNrPagini";
            this.lbNrPagini.Size = new System.Drawing.Size(136, 24);
            this.lbNrPagini.TabIndex = 64;
            this.lbNrPagini.Text = "Numar Pagini";
            // 
            // tbPret
            // 
            this.tbPret.DecimalPlaces = 2;
            this.tbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPret.Location = new System.Drawing.Point(1160, 126);
            this.tbPret.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(219, 26);
            this.tbPret.TabIndex = 66;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCantitate.Location = new System.Drawing.Point(1160, 158);
            this.tbCantitate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(219, 26);
            this.tbCantitate.TabIndex = 67;
            // 
            // tbAn
            // 
            this.tbAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAn.Location = new System.Drawing.Point(1160, 220);
            this.tbAn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(219, 26);
            this.tbAn.TabIndex = 68;
            // 
            // tbNrPagini
            // 
            this.tbNrPagini.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNrPagini.Location = new System.Drawing.Point(1160, 252);
            this.tbNrPagini.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNrPagini.Name = "tbNrPagini";
            this.tbNrPagini.Size = new System.Drawing.Size(219, 26);
            this.tbNrPagini.TabIndex = 69;
            // 
            // furnizorBindingSource
            // 
            this.furnizorBindingSource.DataMember = "furnizor";
            this.furnizorBindingSource.DataSource = this.librarieDataSet;
            // 
            // furnizorTableAdapter
            // 
            this.furnizorTableAdapter.ClearBeforeFill = true;
            // 
            // Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1411, 544);
            this.Controls.Add(this.tbNrPagini);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.lbNrPagini);
            this.Controls.Add(this.lbAn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.cmbTipProdus);
            this.Controls.Add(this.lblProdus);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.cmbEditura);
            this.Controls.Add(this.cmbDomeniu);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.lblEditura);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblDomeniu);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblAutor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Produse";
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.Produse_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartedetaliuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNrPagini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Label lblDomeniu;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblEditura;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.ComboBox cmbDomeniu;
        private System.Windows.Forms.ComboBox cmbEditura;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginăPrincipalăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edituriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cliențiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vânzăriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solduriFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cărțiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource cartedetaliuBindingSource;
        private LibrarieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.ComboBox cmbTipProdus;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarieDataSetTableAdapters.cartedetaliuTableAdapter cartedetaliuTableAdapter;
        private System.Windows.Forms.Label lbAn;
        private System.Windows.Forms.Label lbNrPagini;
        private System.Windows.Forms.NumericUpDown tbPret;
        private System.Windows.Forms.NumericUpDown tbCantitate;
        private System.Windows.Forms.NumericUpDown tbAn;
        private System.Windows.Forms.NumericUpDown tbNrPagini;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPaginiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domeniuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edituraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource furnizorBindingSource;
        private LibrarieDataSetTableAdapters.furnizorTableAdapter furnizorTableAdapter;
    }
}