namespace Program_Librarie
{
    partial class AdaugaClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaClient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.clientTableAdapter();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVarsta = new System.Windows.Forms.NumericUpDown();
            this.tbNume = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVarsta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(781, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vârstă";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sex";
            // 
            // cmbSex
            // 
            this.cmbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "masculin",
            "feminin"});
            this.cmbSex.Location = new System.Drawing.Point(732, 262);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(219, 28);
            this.cmbSex.TabIndex = 7;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(781, 363);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(170, 38);
            this.btnStergere.TabIndex = 72;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(598, 414);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(170, 38);
            this.btnModifica.TabIndex = 69;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btnRenuntare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.Location = new System.Drawing.Point(781, 414);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(170, 38);
            this.btnRenuntare.TabIndex = 68;
            this.btnRenuntare.Text = "Renunță";
            this.btnRenuntare.UseVisualStyleBackColor = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(598, 363);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(170, 38);
            this.btnAdaugare.TabIndex = 67;
            this.btnAdaugare.Text = "Adaugă";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
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
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(732, 294);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 26);
            this.tbEmail.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 73;
            this.label4.Text = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.varstaDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 411);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.librarieDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varstaDataGridViewTextBoxColumn
            // 
            this.varstaDataGridViewTextBoxColumn.DataPropertyName = "Varsta";
            this.varstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            this.varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
            this.varstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbVarsta
            // 
            this.tbVarsta.DecimalPlaces = 2;
            this.tbVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbVarsta.Location = new System.Drawing.Point(732, 231);
            this.tbVarsta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(219, 26);
            this.tbVarsta.TabIndex = 76;
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.Location = new System.Drawing.Point(732, 200);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(219, 26);
            this.tbNume.TabIndex = 77;
            // 
            // AdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(980, 493);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdaugaClient";
            this.Text = "AdaugaClient";
            this.Load += new System.EventHandler(this.AdaugaClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVarsta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnAdaugare;
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
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private LibrarieDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown tbVarsta;
        private System.Windows.Forms.TextBox tbNume;
    }
}