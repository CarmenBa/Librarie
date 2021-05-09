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
            this.btnCauta = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauta.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(549, 280);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(226, 47);
            this.btnCauta.TabIndex = 64;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 32);
            this.dateTimePicker1.TabIndex = 68;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 13, 26, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 134);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectează perioada dorită";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 69;
            this.label5.Text = "Până la";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(140, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 32);
            this.dateTimePicker2.TabIndex = 70;
            this.dateTimePicker2.Value = new System.DateTime(2020, 1, 1, 13, 29, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 63;
            this.label1.Text = "Din data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 295);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selectează modalitatea de căutare";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Unicode MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(35, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(249, 34);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Selectează perioadă";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Unicode MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(35, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(195, 34);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Toate vânzările";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginăPrincipalăToolStripMenuItem
            // 
            this.paginăPrincipalăToolStripMenuItem.Name = "paginăPrincipalăToolStripMenuItem";
            this.paginăPrincipalăToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
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
            this.adaugăToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.adaugăToolStripMenuItem.Text = "Adaugă";
            // 
            // cărțiToolStripMenuItem
            // 
            this.cărțiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoriToolStripMenuItem,
            this.edituriToolStripMenuItem,
            this.cărțiToolStripMenuItem1});
            this.cărțiToolStripMenuItem.Name = "cărțiToolStripMenuItem";
            this.cărțiToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.cărțiToolStripMenuItem.Text = "Cărți și despre cărți";
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.autoriToolStripMenuItem.Text = "Autori";
            // 
            // edituriToolStripMenuItem
            // 
            this.edituriToolStripMenuItem.Name = "edituriToolStripMenuItem";
            this.edituriToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.edituriToolStripMenuItem.Text = "Edituri";
            // 
            // cărțiToolStripMenuItem1
            // 
            this.cărțiToolStripMenuItem1.Name = "cărțiToolStripMenuItem1";
            this.cărțiToolStripMenuItem1.Size = new System.Drawing.Size(127, 26);
            this.cărțiToolStripMenuItem1.Text = "Cărți";
            // 
            // echipamenteDeBiroticaToolStripMenuItem
            // 
            this.echipamenteDeBiroticaToolStripMenuItem.Name = "echipamenteDeBiroticaToolStripMenuItem";
            this.echipamenteDeBiroticaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.echipamenteDeBiroticaToolStripMenuItem.Text = "Echipamente de birotica";
            // 
            // cliențiToolStripMenuItem
            // 
            this.cliențiToolStripMenuItem.Name = "cliențiToolStripMenuItem";
            this.cliențiToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.cliențiToolStripMenuItem.Text = "Clienți";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
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
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // vânzăriToolStripMenuItem
            // 
            this.vânzăriToolStripMenuItem.Name = "vânzăriToolStripMenuItem";
            this.vânzăriToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.vânzăriToolStripMenuItem.Text = "Vânzări";
            // 
            // stocuriToolStripMenuItem
            // 
            this.stocuriToolStripMenuItem.Name = "stocuriToolStripMenuItem";
            this.stocuriToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.stocuriToolStripMenuItem.Text = "Stocuri";
            // 
            // solduriFurnizoriToolStripMenuItem
            // 
            this.solduriFurnizoriToolStripMenuItem.Name = "solduriFurnizoriToolStripMenuItem";
            this.solduriFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.solduriFurnizoriToolStripMenuItem.Text = "Solduri Furnizori";
            // 
            // cărțiToolStripMenuItem2
            // 
            this.cărțiToolStripMenuItem2.Name = "cărțiToolStripMenuItem2";
            this.cărțiToolStripMenuItem2.Size = new System.Drawing.Size(192, 26);
            this.cărțiToolStripMenuItem2.Text = "Produse";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // Vanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 361);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCauta);
            this.Name = "Vanzari";
            this.Text = "Vanzari";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
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
    }
}