namespace Program_Librarie
{
    partial class Autori
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
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarieDataSet = new Program_Librarie.LibrarieDataSet();
            this.autorTableAdapter = new Program_Librarie.LibrarieDataSetTableAdapters.autorTableAdapter();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(679, 25);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginăPrincipalăToolStripMenuItem
            // 
            this.paginăPrincipalăToolStripMenuItem.Name = "paginăPrincipalăToolStripMenuItem";
            this.paginăPrincipalăToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
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
            this.adaugăToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
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
            this.produseToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
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
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(432, 148);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(226, 47);
            this.btnModifica.TabIndex = 50;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(432, 254);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(226, 47);
            this.btnStergere.TabIndex = 49;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(432, 201);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(226, 47);
            this.btnAdaugare.TabIndex = 48;
            this.btnAdaugare.Text = "Adaugă";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutorDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(395, 256);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "IdAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "IdAutor";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            this.idAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAutorDataGridViewTextBoxColumn.Width = 70;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 250;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "autor";
            this.autorBindingSource.DataSource = this.librarieDataSet;
            // 
            // librarieDataSet
            // 
            this.librarieDataSet.DataSetName = "LibrarieDataSet";
            this.librarieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.Location = new System.Drawing.Point(432, 103);
            this.tbNume.Margin = new System.Windows.Forms.Padding(2);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(226, 26);
            this.tbNume.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nume";
            // 
            // Autori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(679, 317);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Autori";
            this.Text = "Autori";
            this.Load += new System.EventHandler(this.Autori_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibrarieDataSet librarieDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private LibrarieDataSetTableAdapters.autorTableAdapter autorTableAdapter;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
    }
}