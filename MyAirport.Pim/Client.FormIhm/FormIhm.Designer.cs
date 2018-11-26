namespace MyAirport.Pim.Client
{
    partial class FormIhm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pimStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attenteBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_RECHERCHE = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GB_RESULTAT = new System.Windows.Forms.GroupBox();
            this.GB_BAGAGE = new System.Windows.Forms.GroupBox();
            this.GB_VOL = new System.Windows.Forms.GroupBox();
            this.textBoxJour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxLigne = new System.Windows.Forms.TextBox();
            this.textboxCompanie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.GB_RECHERCHE.SuspendLayout();
            this.GB_RESULTAT.SuspendLayout();
            this.GB_VOL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pimStateToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 27);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1336, 40);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // pimStateToolStripMenuItem
            // 
            this.pimStateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnecterToolStripMenuItem,
            this.attenteBagageToolStripMenuItem,
            this.selectionBagageToolStripMenuItem,
            this.creationBagageToolStripMenuItem,
            this.affichageBagageToolStripMenuItem});
            this.pimStateToolStripMenuItem.Name = "pimStateToolStripMenuItem";
            this.pimStateToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.pimStateToolStripMenuItem.Text = "PimState";
            // 
            // deconnecterToolStripMenuItem
            // 
            this.deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            this.deconnecterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deconnecterToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.deconnecterToolStripMenuItem.Text = "Deconnecter";
            this.deconnecterToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
            // 
            // attenteBagageToolStripMenuItem
            // 
            this.attenteBagageToolStripMenuItem.Name = "attenteBagageToolStripMenuItem";
            this.attenteBagageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.attenteBagageToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.attenteBagageToolStripMenuItem.Text = "Attente Bagage";
            this.attenteBagageToolStripMenuItem.Click += new System.EventHandler(this.attenteBagageToolStripMenuItem_Click);
            // 
            // selectionBagageToolStripMenuItem
            // 
            this.selectionBagageToolStripMenuItem.Name = "selectionBagageToolStripMenuItem";
            this.selectionBagageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.selectionBagageToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.selectionBagageToolStripMenuItem.Text = "Selection Bagage";
            this.selectionBagageToolStripMenuItem.Click += new System.EventHandler(this.selectionBagageToolStripMenuItem_Click);
            // 
            // creationBagageToolStripMenuItem
            // 
            this.creationBagageToolStripMenuItem.Name = "creationBagageToolStripMenuItem";
            this.creationBagageToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.creationBagageToolStripMenuItem.Text = "Creation Bagage";
            this.creationBagageToolStripMenuItem.Click += new System.EventHandler(this.creationBagageToolStripMenuItem_Click);
            // 
            // affichageBagageToolStripMenuItem
            // 
            this.affichageBagageToolStripMenuItem.Name = "affichageBagageToolStripMenuItem";
            this.affichageBagageToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.affichageBagageToolStripMenuItem.Text = "Affichage Bagage";
            this.affichageBagageToolStripMenuItem.Click += new System.EventHandler(this.affichageBagageToolStripMenuItem_Click);
            // 
            // GB_RECHERCHE
            // 
            this.GB_RECHERCHE.BackColor = System.Drawing.Color.Red;
            this.GB_RECHERCHE.Controls.Add(this.comboBox1);
            this.GB_RECHERCHE.Controls.Add(this.label1);
            this.GB_RECHERCHE.Controls.Add(this.button1);
            this.GB_RECHERCHE.Controls.Add(this.menuStrip2);
            this.GB_RECHERCHE.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_RECHERCHE.Location = new System.Drawing.Point(0, 0);
            this.GB_RECHERCHE.Name = "GB_RECHERCHE";
            this.GB_RECHERCHE.Size = new System.Drawing.Size(1342, 210);
            this.GB_RECHERCHE.TabIndex = 3;
            this.GB_RECHERCHE.TabStop = false;
            this.GB_RECHERCHE.Text = "Recherche";
            this.GB_RECHERCHE.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "005725273300",
            "012409579000",
            "012409579078"});
            this.comboBox1.Location = new System.Drawing.Point(275, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code IATA";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1113, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GB_RESULTAT
            // 
            this.GB_RESULTAT.BackColor = System.Drawing.Color.Blue;
            this.GB_RESULTAT.Controls.Add(this.GB_BAGAGE);
            this.GB_RESULTAT.Controls.Add(this.GB_VOL);
            this.GB_RESULTAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_RESULTAT.Location = new System.Drawing.Point(0, 210);
            this.GB_RESULTAT.Name = "GB_RESULTAT";
            this.GB_RESULTAT.Size = new System.Drawing.Size(1342, 519);
            this.GB_RESULTAT.TabIndex = 4;
            this.GB_RESULTAT.TabStop = false;
            this.GB_RESULTAT.Text = "Resultat";
            // 
            // GB_BAGAGE
            // 
            this.GB_BAGAGE.BackColor = System.Drawing.Color.Lime;
            this.GB_BAGAGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_BAGAGE.Location = new System.Drawing.Point(491, 27);
            this.GB_BAGAGE.Name = "GB_BAGAGE";
            this.GB_BAGAGE.Size = new System.Drawing.Size(848, 489);
            this.GB_BAGAGE.TabIndex = 6;
            this.GB_BAGAGE.TabStop = false;
            this.GB_BAGAGE.Text = "Bagage";
            // 
            // GB_VOL
            // 
            this.GB_VOL.BackColor = System.Drawing.Color.Yellow;
            this.GB_VOL.Controls.Add(this.textBoxJour);
            this.GB_VOL.Controls.Add(this.label4);
            this.GB_VOL.Controls.Add(this.textboxLigne);
            this.GB_VOL.Controls.Add(this.textboxCompanie);
            this.GB_VOL.Controls.Add(this.label3);
            this.GB_VOL.Controls.Add(this.label2);
            this.GB_VOL.Dock = System.Windows.Forms.DockStyle.Left;
            this.GB_VOL.Location = new System.Drawing.Point(3, 27);
            this.GB_VOL.Name = "GB_VOL";
            this.GB_VOL.Size = new System.Drawing.Size(488, 489);
            this.GB_VOL.TabIndex = 5;
            this.GB_VOL.TabStop = false;
            this.GB_VOL.Text = "Vol";
            // 
            // textBoxJour
            // 
            this.textBoxJour.Location = new System.Drawing.Point(83, 332);
            this.textBoxJour.Name = "textBoxJour";
            this.textBoxJour.Size = new System.Drawing.Size(276, 31);
            this.textBoxJour.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jour d\'exploitation";
            // 
            // textboxLigne
            // 
            this.textboxLigne.Location = new System.Drawing.Point(81, 224);
            this.textboxLigne.Name = "textboxLigne";
            this.textboxLigne.Size = new System.Drawing.Size(276, 31);
            this.textboxLigne.TabIndex = 3;
            this.textboxLigne.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textboxCompanie
            // 
            this.textboxCompanie.Location = new System.Drawing.Point(81, 124);
            this.textboxCompanie.Name = "textboxCompanie";
            this.textboxCompanie.Size = new System.Drawing.Size(276, 31);
            this.textboxCompanie.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ligne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Compagnie";
            // 
            // FormIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 729);
            this.Controls.Add(this.GB_RESULTAT);
            this.Controls.Add(this.GB_RECHERCHE);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "FormIhm";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.GB_RECHERCHE.ResumeLayout(false);
            this.GB_RECHERCHE.PerformLayout();
            this.GB_RESULTAT.ResumeLayout(false);
            this.GB_VOL.ResumeLayout(false);
            this.GB_VOL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_RECHERCHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pimStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attenteBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageBagageToolStripMenuItem;
        private System.Windows.Forms.GroupBox GB_RESULTAT;
        private System.Windows.Forms.GroupBox GB_VOL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxLigne;
        private System.Windows.Forms.TextBox textboxCompanie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GB_BAGAGE;
        private System.Windows.Forms.TextBox textBoxJour;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

