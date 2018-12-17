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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pimStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attenteBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creationBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageBagageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_RECHERCHE = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.GB_RESULTAT = new System.Windows.Forms.GroupBox();
            this.GB_BAGAGE = new System.Windows.Forms.GroupBox();
            this.GB_VOL = new System.Windows.Forms.GroupBox();
            this.textBoxJour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxLigne = new System.Windows.Forms.TextBox();
            this.textboxCompanie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.GB_RECHERCHE.SuspendLayout();
            this.GB_RESULTAT.SuspendLayout();
            this.GB_BAGAGE.SuspendLayout();
            this.GB_VOL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pimStateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
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
            this.pimStateToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.pimStateToolStripMenuItem.Text = "PimState";
            // 
            // deconnecterToolStripMenuItem
            // 
            this.deconnecterToolStripMenuItem.Name = "deconnecterToolStripMenuItem";
            this.deconnecterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deconnecterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.deconnecterToolStripMenuItem.Text = "Deconnecter";
            this.deconnecterToolStripMenuItem.Click += new System.EventHandler(this.deconnecterToolStripMenuItem_Click);
            // 
            // attenteBagageToolStripMenuItem
            // 
            this.attenteBagageToolStripMenuItem.Name = "attenteBagageToolStripMenuItem";
            this.attenteBagageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.attenteBagageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.attenteBagageToolStripMenuItem.Text = "Attente Bagage";
            this.attenteBagageToolStripMenuItem.Click += new System.EventHandler(this.attenteBagageToolStripMenuItem_Click);
            // 
            // selectionBagageToolStripMenuItem
            // 
            this.selectionBagageToolStripMenuItem.Name = "selectionBagageToolStripMenuItem";
            this.selectionBagageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.selectionBagageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.selectionBagageToolStripMenuItem.Text = "Selection Bagage";
            this.selectionBagageToolStripMenuItem.Click += new System.EventHandler(this.selectionBagageToolStripMenuItem_Click);
            // 
            // creationBagageToolStripMenuItem
            // 
            this.creationBagageToolStripMenuItem.Name = "creationBagageToolStripMenuItem";
            this.creationBagageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.creationBagageToolStripMenuItem.Text = "Creation Bagage";
            this.creationBagageToolStripMenuItem.Click += new System.EventHandler(this.creationBagageToolStripMenuItem_Click);
            // 
            // affichageBagageToolStripMenuItem
            // 
            this.affichageBagageToolStripMenuItem.Name = "affichageBagageToolStripMenuItem";
            this.affichageBagageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.affichageBagageToolStripMenuItem.Text = "Affichage Bagage";
            this.affichageBagageToolStripMenuItem.Click += new System.EventHandler(this.affichageBagageToolStripMenuItem_Click);
            // 
            // GB_RECHERCHE
            // 
            this.GB_RECHERCHE.BackColor = System.Drawing.Color.Red;
            this.GB_RECHERCHE.Controls.Add(this.comboBox1);
            this.GB_RECHERCHE.Controls.Add(this.label1);
            this.GB_RECHERCHE.Controls.Add(this.buttonRechercher);
            this.GB_RECHERCHE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_RECHERCHE.Location = new System.Drawing.Point(0, 0);
            this.GB_RECHERCHE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_RECHERCHE.Name = "GB_RECHERCHE";
            this.GB_RECHERCHE.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_RECHERCHE.Size = new System.Drawing.Size(671, 396);
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
            this.comboBox1.Location = new System.Drawing.Point(138, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code IATA";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRechercher.Location = new System.Drawing.Point(556, 55);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(94, 41);
            this.buttonRechercher.TabIndex = 0;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GB_RESULTAT
            // 
            this.GB_RESULTAT.BackColor = System.Drawing.Color.Blue;
            this.GB_RESULTAT.Controls.Add(this.GB_BAGAGE);
            this.GB_RESULTAT.Controls.Add(this.GB_VOL);
            this.GB_RESULTAT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GB_RESULTAT.Location = new System.Drawing.Point(0, 144);
            this.GB_RESULTAT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_RESULTAT.Name = "GB_RESULTAT";
            this.GB_RESULTAT.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_RESULTAT.Size = new System.Drawing.Size(671, 252);
            this.GB_RESULTAT.TabIndex = 4;
            this.GB_RESULTAT.TabStop = false;
            this.GB_RESULTAT.Text = "Resultat";
            // 
            // GB_BAGAGE
            // 
            this.GB_BAGAGE.BackColor = System.Drawing.Color.Lime;
            this.GB_BAGAGE.Controls.Add(this.listBoxLogs);
            this.GB_BAGAGE.Dock = System.Windows.Forms.DockStyle.Right;
            this.GB_BAGAGE.Location = new System.Drawing.Point(245, 15);
            this.GB_BAGAGE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_BAGAGE.Name = "GB_BAGAGE";
            this.GB_BAGAGE.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_BAGAGE.Size = new System.Drawing.Size(424, 235);
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
            this.GB_VOL.Location = new System.Drawing.Point(2, 15);
            this.GB_VOL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_VOL.Name = "GB_VOL";
            this.GB_VOL.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_VOL.Size = new System.Drawing.Size(244, 235);
            this.GB_VOL.TabIndex = 5;
            this.GB_VOL.TabStop = false;
            this.GB_VOL.Text = "Vol";
            // 
            // textBoxJour
            // 
            this.textBoxJour.Location = new System.Drawing.Point(42, 173);
            this.textBoxJour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxJour.Name = "textBoxJour";
            this.textBoxJour.Size = new System.Drawing.Size(140, 20);
            this.textBoxJour.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jour d\'exploitation";
            // 
            // textboxLigne
            // 
            this.textboxLigne.Location = new System.Drawing.Point(40, 116);
            this.textboxLigne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxLigne.Name = "textboxLigne";
            this.textboxLigne.Size = new System.Drawing.Size(140, 20);
            this.textboxLigne.TabIndex = 3;
            this.textboxLigne.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textboxCompanie
            // 
            this.textboxCompanie.Location = new System.Drawing.Point(40, 64);
            this.textboxCompanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxCompanie.Name = "textboxCompanie";
            this.textboxCompanie.Size = new System.Drawing.Size(140, 20);
            this.textboxCompanie.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ligne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Compagnie";
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(15, 41);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(120, 95);
            this.listBoxLogs.TabIndex = 0;
            // 
            // FormIhm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 396);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_RESULTAT);
            this.Controls.Add(this.GB_RECHERCHE);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(308, 435);
            this.Name = "FormIhm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GB_RECHERCHE.ResumeLayout(false);
            this.GB_RECHERCHE.PerformLayout();
            this.GB_RESULTAT.ResumeLayout(false);
            this.GB_BAGAGE.ResumeLayout(false);
            this.GB_VOL.ResumeLayout(false);
            this.GB_VOL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pimStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attenteBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creationBagageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageBagageToolStripMenuItem;

        private System.Windows.Forms.GroupBox GB_RECHERCHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRechercher;
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
        private System.Windows.Forms.ListBox listBoxLogs;
    }
}

