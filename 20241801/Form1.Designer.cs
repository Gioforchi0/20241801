namespace _20241801
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            chiudiMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            inserisci_btn = new Button();
            prezzo_txt = new TextBox();
            prodotto_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            aggiungi_btn = new Button();
            quantita_cb = new ComboBox();
            prezzi_lb = new ListBox();
            prodotti_lb = new ListBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            totale_txt = new TextBox();
            importi_lb = new ListBox();
            acquisti_lb = new ListBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            esci_btn = new Button();
            disattivato_check = new CheckBox();
            nuovo_btn = new Button();
            svuota_btn = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chiudiMenu });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // chiudiMenu
            // 
            chiudiMenu.Name = "chiudiMenu";
            chiudiMenu.Size = new Size(180, 22);
            chiudiMenu.Text = "chiudi";
            chiudiMenu.Click += chiudiToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(inserisci_btn);
            panel1.Controls.Add(prezzo_txt);
            panel1.Controls.Add(prodotto_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 153);
            panel1.TabIndex = 1;
            // 
            // inserisci_btn
            // 
            inserisci_btn.Location = new Point(17, 95);
            inserisci_btn.Name = "inserisci_btn";
            inserisci_btn.Size = new Size(206, 45);
            inserisci_btn.TabIndex = 5;
            inserisci_btn.Text = "Inserisci prodotto negli elenchi qui sotto";
            inserisci_btn.UseVisualStyleBackColor = true;
            // 
            // prezzo_txt
            // 
            prezzo_txt.Location = new Point(123, 66);
            prezzo_txt.Name = "prezzo_txt";
            prezzo_txt.Size = new Size(100, 23);
            prezzo_txt.TabIndex = 4;
            // 
            // prodotto_txt
            // 
            prodotto_txt.Location = new Point(17, 66);
            prodotto_txt.Name = "prodotto_txt";
            prodotto_txt.Size = new Size(100, 23);
            prodotto_txt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 39);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 2;
            label4.Text = "Prezzo al kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 39);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "descrizione";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(45, 7);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "NUOVO PRODOTTO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(aggiungi_btn);
            panel2.Controls.Add(quantita_cb);
            panel2.Controls.Add(prezzi_lb);
            panel2.Controls.Add(prodotti_lb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 356);
            panel2.TabIndex = 2;
            // 
            // aggiungi_btn
            // 
            aggiungi_btn.Enabled = false;
            aggiungi_btn.Location = new Point(98, 298);
            aggiungi_btn.Name = "aggiungi_btn";
            aggiungi_btn.Size = new Size(114, 44);
            aggiungi_btn.TabIndex = 7;
            aggiungi_btn.Text = "Aggiungi allo scontrino";
            aggiungi_btn.UseVisualStyleBackColor = true;
            // 
            // quantita_cb
            // 
            quantita_cb.Enabled = false;
            quantita_cb.FormattingEnabled = true;
            quantita_cb.Location = new Point(17, 310);
            quantita_cb.Name = "quantita_cb";
            quantita_cb.Size = new Size(38, 23);
            quantita_cb.TabIndex = 6;
            // 
            // prezzi_lb
            // 
            prezzi_lb.Enabled = false;
            prezzi_lb.FormattingEnabled = true;
            prezzi_lb.ItemHeight = 15;
            prezzi_lb.Location = new Point(143, 59);
            prezzi_lb.Name = "prezzi_lb";
            prezzi_lb.Size = new Size(69, 229);
            prezzi_lb.TabIndex = 5;
            // 
            // prodotti_lb
            // 
            prodotti_lb.Enabled = false;
            prodotti_lb.FormattingEnabled = true;
            prodotti_lb.ItemHeight = 15;
            prodotti_lb.Location = new Point(17, 59);
            prodotti_lb.Name = "prodotti_lb";
            prodotti_lb.Size = new Size(120, 229);
            prodotti_lb.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 292);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 3;
            label8.Text = "Quantità";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 41);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 2;
            label7.Text = "Prezzo al kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 41);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 1;
            label6.Text = "Descrizione";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(23, 11);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 0;
            label5.Text = "CATALOGO ED ACQUISTO";
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(totale_txt);
            panel3.Controls.Add(importi_lb);
            panel3.Controls.Add(acquisti_lb);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(255, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 515);
            panel3.TabIndex = 3;
            // 
            // totale_txt
            // 
            totale_txt.Location = new Point(84, 441);
            totale_txt.Name = "totale_txt";
            totale_txt.Size = new Size(100, 23);
            totale_txt.TabIndex = 7;
            // 
            // importi_lb
            // 
            importi_lb.Enabled = false;
            importi_lb.FormattingEnabled = true;
            importi_lb.ItemHeight = 15;
            importi_lb.Location = new Point(141, 95);
            importi_lb.Name = "importi_lb";
            importi_lb.Size = new Size(125, 304);
            importi_lb.TabIndex = 6;
            // 
            // acquisti_lb
            // 
            acquisti_lb.Enabled = false;
            acquisti_lb.FormattingEnabled = true;
            acquisti_lb.ItemHeight = 15;
            acquisti_lb.Location = new Point(15, 95);
            acquisti_lb.Name = "acquisti_lb";
            acquisti_lb.Size = new Size(120, 304);
            acquisti_lb.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(15, 444);
            label12.Name = "label12";
            label12.Size = new Size(23, 25);
            label12.TabIndex = 4;
            label12.Text = "€";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(105, 418);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 3;
            label11.Text = "TOTALE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(165, 69);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 2;
            label10.Text = "Importi da pagare";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 66);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 1;
            label9.Text = "Prodotti acquistati";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(74, 7);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 0;
            label2.Text = "SCONTRINO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money;
            pictureBox1.Location = new Point(565, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // esci_btn
            // 
            esci_btn.Location = new Point(565, 443);
            esci_btn.Name = "esci_btn";
            esci_btn.Size = new Size(146, 76);
            esci_btn.TabIndex = 5;
            esci_btn.Text = "Esci";
            esci_btn.UseVisualStyleBackColor = true;
            // 
            // disattivato_check
            // 
            disattivato_check.AutoSize = true;
            disattivato_check.Location = new Point(758, 472);
            disattivato_check.Name = "disattivato_check";
            disattivato_check.Size = new Size(132, 19);
            disattivato_check.TabIndex = 6;
            disattivato_check.Text = "Disattivazione totale";
            disattivato_check.UseVisualStyleBackColor = true;
            // 
            // nuovo_btn
            // 
            nuovo_btn.Location = new Point(758, 52);
            nuovo_btn.Name = "nuovo_btn";
            nuovo_btn.Size = new Size(142, 64);
            nuovo_btn.TabIndex = 7;
            nuovo_btn.Text = "Nuovo scontrino";
            nuovo_btn.UseVisualStyleBackColor = true;
            // 
            // svuota_btn
            // 
            svuota_btn.Location = new Point(565, 52);
            svuota_btn.Name = "svuota_btn";
            svuota_btn.Size = new Size(146, 64);
            svuota_btn.TabIndex = 8;
            svuota_btn.Text = "Svuota tutto";
            svuota_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 554);
            Controls.Add(svuota_btn);
            Controls.Add(nuovo_btn);
            Controls.Add(disattivato_check);
            Controls.Add(esci_btn);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scontrino";
            Activated += Form1_Activated;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem chiudiMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
        private Button inserisci_btn;
        private TextBox prezzo_txt;
        private TextBox prodotto_txt;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Button aggiungi_btn;
        private ComboBox quantita_cb;
        private ListBox prezzi_lb;
        private ListBox prodotti_lb;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private TextBox totale_txt;
        private ListBox importi_lb;
        private ListBox acquisti_lb;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label2;
        private PictureBox pictureBox1;
        private Button esci_btn;
        private CheckBox disattivato_check;
        private Button nuovo_btn;
        private Button svuota_btn;
    }
}