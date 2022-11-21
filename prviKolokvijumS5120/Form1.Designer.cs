namespace prviKolokvijumS5120
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.rtbGlavni = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnZameni = new System.Windows.Forms.Button();
            this.tbPronadji = new System.Windows.Forms.TextBox();
            this.tbZameni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZavrsi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZavrsi.Image = ((System.Drawing.Image)(resources.GetObject("btnZavrsi.Image")));
            this.btnZavrsi.Location = new System.Drawing.Point(485, 10);
            this.btnZavrsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(92, 74);
            this.btnZavrsi.TabIndex = 0;
            this.btnZavrsi.Text = "Zavrsi program";
            this.btnZavrsi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Image = ((System.Drawing.Image)(resources.GetObject("btnOtvori.Image")));
            this.btnOtvori.Location = new System.Drawing.Point(9, 9);
            this.btnOtvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(98, 75);
            this.btnOtvori.TabIndex = 1;
            this.btnOtvori.Text = "Otvori fajl";
            this.btnOtvori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // rtbGlavni
            // 
            this.rtbGlavni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGlavni.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbGlavni.Location = new System.Drawing.Point(9, 110);
            this.rtbGlavni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbGlavni.Name = "rtbGlavni";
            this.rtbGlavni.Size = new System.Drawing.Size(569, 323);
            this.rtbGlavni.TabIndex = 2;
            this.rtbGlavni.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBoldToolStripMenuItem,
            this.fontItalicToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 98);
            // 
            // fontBoldToolStripMenuItem
            // 
            this.fontBoldToolStripMenuItem.Name = "fontBoldToolStripMenuItem";
            this.fontBoldToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontBoldToolStripMenuItem.Text = "Font Bold";
            this.fontBoldToolStripMenuItem.Click += new System.EventHandler(this.fontBoldToolStripMenuItem_Click);
            // 
            // fontItalicToolStripMenuItem
            // 
            this.fontItalicToolStripMenuItem.Name = "fontItalicToolStripMenuItem";
            this.fontItalicToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontItalicToolStripMenuItem.Text = "Font Italic";
            this.fontItalicToolStripMenuItem.Click += new System.EventHandler(this.fontItalicToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontColorToolStripMenuItem.Text = "Font Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnimi.Image = ((System.Drawing.Image)(resources.GetObject("btnSnimi.Image")));
            this.btnSnimi.Location = new System.Drawing.Point(392, 11);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(80, 73);
            this.btnSnimi.TabIndex = 3;
            this.btnSnimi.Text = "Snimi fajl";
            this.btnSnimi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnZameni
            // 
            this.btnZameni.Image = ((System.Drawing.Image)(resources.GetObject("btnZameni.Image")));
            this.btnZameni.Location = new System.Drawing.Point(268, 11);
            this.btnZameni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZameni.Name = "btnZameni";
            this.btnZameni.Size = new System.Drawing.Size(80, 73);
            this.btnZameni.TabIndex = 4;
            this.btnZameni.Text = "Pronadji i zameni";
            this.btnZameni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZameni.UseVisualStyleBackColor = true;
            this.btnZameni.Click += new System.EventHandler(this.btnZameni_Click);
            // 
            // tbPronadji
            // 
            this.tbPronadji.Location = new System.Drawing.Point(174, 23);
            this.tbPronadji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPronadji.Name = "tbPronadji";
            this.tbPronadji.Size = new System.Drawing.Size(76, 20);
            this.tbPronadji.TabIndex = 5;
            // 
            // tbZameni
            // 
            this.tbZameni.Location = new System.Drawing.Point(174, 57);
            this.tbZameni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbZameni.Name = "tbZameni";
            this.tbZameni.Size = new System.Drawing.Size(76, 20);
            this.tbZameni.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronadji";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zameni sa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZavrsi;
            this.ClientSize = new System.Drawing.Size(586, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbZameni);
            this.Controls.Add(this.tbPronadji);
            this.Controls.Add(this.btnZameni);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.rtbGlavni);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.btnZavrsi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Milorad Milic S51/20";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.RichTextBox rtbGlavni;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.Button btnZameni;
        private System.Windows.Forms.TextBox tbPronadji;
        private System.Windows.Forms.TextBox tbZameni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

