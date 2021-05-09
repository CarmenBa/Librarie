namespace Program_Librarie
{
    partial class Furnizor
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
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCUI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.furnizorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.furnizorTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.furnizorTableAdapter();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbSold = new System.Windows.Forms.NumericUpDown();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSold)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(690, 235);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(170, 38);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btnRenuntare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.Location = new System.Drawing.Point(864, 235);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(170, 38);
            this.btnRenuntare.TabIndex = 12;
            this.btnRenuntare.Text = "Renunță";
            this.btnRenuntare.UseVisualStyleBackColor = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(690, 193);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(170, 38);
            this.btnAdaugare.TabIndex = 11;
            this.btnAdaugare.Text = "Adaugă";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nume";
            // 
            // tbCUI
            // 
            this.tbCUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCUI.Location = new System.Drawing.Point(815, 73);
            this.tbCUI.Margin = new System.Windows.Forms.Padding(2);
            this.tbCUI.Name = "tbCUI";
            this.tbCUI.Size = new System.Drawing.Size(219, 26);
            this.tbCUI.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "CUI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sold";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(815, 133);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 26);
            this.tbEmail.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefon.Location = new System.Drawing.Point(815, 163);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(219, 26);
            this.tbTelefon.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(698, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefon";
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(864, 193);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(170, 38);
            this.btnStergere.TabIndex = 50;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFurnizorDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.cUIDataGridViewTextBoxColumn,
            this.soldDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Telefon});
            this.dataGridView1.DataSource = this.furnizorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(664, 232);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // furnizorBindingSource
            // 
            this.furnizorBindingSource.DataMember = "furnizor";
            this.furnizorBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnizorTableAdapter
            // 
            this.furnizorTableAdapter.ClearBeforeFill = true;
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.Location = new System.Drawing.Point(815, 43);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(219, 26);
            this.tbNume.TabIndex = 53;
            // 
            // tbSold
            // 
            this.tbSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSold.Location = new System.Drawing.Point(815, 104);
            this.tbSold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbSold.Name = "tbSold";
            this.tbSold.Size = new System.Drawing.Size(219, 26);
            this.tbSold.TabIndex = 77;
            // 
            // idFurnizorDataGridViewTextBoxColumn
            // 
            this.idFurnizorDataGridViewTextBoxColumn.DataPropertyName = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.HeaderText = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.Name = "idFurnizorDataGridViewTextBoxColumn";
            this.idFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFurnizorDataGridViewTextBoxColumn.Visible = false;
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
            // cUIDataGridViewTextBoxColumn
            // 
            this.cUIDataGridViewTextBoxColumn.DataPropertyName = "CUI";
            this.cUIDataGridViewTextBoxColumn.HeaderText = "CUI";
            this.cUIDataGridViewTextBoxColumn.Name = "cUIDataGridViewTextBoxColumn";
            this.cUIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldDataGridViewTextBoxColumn
            // 
            this.soldDataGridViewTextBoxColumn.DataPropertyName = "Sold";
            this.soldDataGridViewTextBoxColumn.HeaderText = "Sold";
            this.soldDataGridViewTextBoxColumn.Name = "soldDataGridViewTextBoxColumn";
            this.soldDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 68;
            // 
            // Furnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1045, 288);
            this.Controls.Add(this.tbSold);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCUI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnAdaugare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Furnizor";
            this.Text = "Furnizor";
            this.Load += new System.EventHandler(this.Furnizor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStergere;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource furnizorBindingSource;
        private LibrarieDataSetTableAdapters.furnizorTableAdapter furnizorTableAdapter;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.NumericUpDown tbSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
    }
}