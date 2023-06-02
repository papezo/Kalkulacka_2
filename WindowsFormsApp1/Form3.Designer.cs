namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_adresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_sit = new System.Windows.Forms.Label();
            this.label_maska = new System.Windows.Forms.Label();
            this.label_prvni = new System.Windows.Forms.Label();
            this.label_posledni = new System.Windows.Forms.Label();
            this.label_broadcast = new System.Windows.Forms.Label();
            this.textBox_maska = new System.Windows.Forms.TextBox();
            this.button_vypocitat = new System.Windows.Forms.Button();
            this.label_wildcard = new System.Windows.Forms.Label();
            this.label_wild = new System.Windows.Forms.Label();
            this.label_trida = new System.Windows.Forms.Label();
            this.label_trid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typKalkulačkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matematickáKalkulačkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.převodMeziSoustavamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(232, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadej IP Adresu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_adresa.Location = new System.Drawing.Point(553, 54);
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.Size = new System.Drawing.Size(545, 62);
            this.textBox_adresa.TabIndex = 1;
            this.textBox_adresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_adresa.TextChanged += new System.EventHandler(this.textBox_zadani_TextChanged);
            this.textBox_adresa.Leave += new System.EventHandler(this.textBox_adresa_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(338, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maska";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(338, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "První použitelná adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(338, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Poslední použitelná adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(338, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Broadcast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(338, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "IP adresa sítě";
            // 
            // label_sit
            // 
            this.label_sit.AutoSize = true;
            this.label_sit.Location = new System.Drawing.Point(824, 344);
            this.label_sit.Name = "label_sit";
            this.label_sit.Size = new System.Drawing.Size(26, 25);
            this.label_sit.TabIndex = 8;
            this.label_sit.Text = "--";
            this.label_sit.Click += new System.EventHandler(this.label_sit_Click);
            // 
            // label_maska
            // 
            this.label_maska.AutoSize = true;
            this.label_maska.Location = new System.Drawing.Point(824, 396);
            this.label_maska.Name = "label_maska";
            this.label_maska.Size = new System.Drawing.Size(26, 25);
            this.label_maska.TabIndex = 9;
            this.label_maska.Text = "--";
            // 
            // label_prvni
            // 
            this.label_prvni.AutoSize = true;
            this.label_prvni.Location = new System.Drawing.Point(824, 443);
            this.label_prvni.Name = "label_prvni";
            this.label_prvni.Size = new System.Drawing.Size(26, 25);
            this.label_prvni.TabIndex = 10;
            this.label_prvni.Text = "--";
            // 
            // label_posledni
            // 
            this.label_posledni.AutoSize = true;
            this.label_posledni.Location = new System.Drawing.Point(824, 489);
            this.label_posledni.Name = "label_posledni";
            this.label_posledni.Size = new System.Drawing.Size(26, 25);
            this.label_posledni.TabIndex = 11;
            this.label_posledni.Text = "--";
            // 
            // label_broadcast
            // 
            this.label_broadcast.AutoSize = true;
            this.label_broadcast.Location = new System.Drawing.Point(824, 531);
            this.label_broadcast.Name = "label_broadcast";
            this.label_broadcast.Size = new System.Drawing.Size(26, 25);
            this.label_broadcast.TabIndex = 12;
            this.label_broadcast.Text = "--";
            // 
            // textBox_maska
            // 
            this.textBox_maska.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_maska.Location = new System.Drawing.Point(553, 127);
            this.textBox_maska.Name = "textBox_maska";
            this.textBox_maska.Size = new System.Drawing.Size(545, 62);
            this.textBox_maska.TabIndex = 13;
            this.textBox_maska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_maska.TextChanged += new System.EventHandler(this.textBox_maska_TextChanged);
            // 
            // button_vypocitat
            // 
            this.button_vypocitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_vypocitat.Location = new System.Drawing.Point(688, 211);
            this.button_vypocitat.Name = "button_vypocitat";
            this.button_vypocitat.Size = new System.Drawing.Size(244, 55);
            this.button_vypocitat.TabIndex = 14;
            this.button_vypocitat.Text = "Vypočítat";
            this.button_vypocitat.UseVisualStyleBackColor = true;
            this.button_vypocitat.Click += new System.EventHandler(this.button_vypocitat_Click_1);
            // 
            // label_wildcard
            // 
            this.label_wildcard.AutoSize = true;
            this.label_wildcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_wildcard.Location = new System.Drawing.Point(338, 570);
            this.label_wildcard.Name = "label_wildcard";
            this.label_wildcard.Size = new System.Drawing.Size(127, 31);
            this.label_wildcard.TabIndex = 15;
            this.label_wildcard.Text = "Wildcard";
            // 
            // label_wild
            // 
            this.label_wild.AutoSize = true;
            this.label_wild.Location = new System.Drawing.Point(824, 576);
            this.label_wild.Name = "label_wild";
            this.label_wild.Size = new System.Drawing.Size(26, 25);
            this.label_wild.TabIndex = 16;
            this.label_wild.Text = "--";
            // 
            // label_trida
            // 
            this.label_trida.AutoSize = true;
            this.label_trida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_trida.Location = new System.Drawing.Point(338, 615);
            this.label_trida.Name = "label_trida";
            this.label_trida.Size = new System.Drawing.Size(159, 31);
            this.label_trida.TabIndex = 17;
            this.label_trida.Text = "Typ adresy";
            // 
            // label_trid
            // 
            this.label_trid.AutoSize = true;
            this.label_trid.Location = new System.Drawing.Point(824, 615);
            this.label_trid.Name = "label_trid";
            this.label_trid.Size = new System.Drawing.Size(26, 25);
            this.label_trid.TabIndex = 18;
            this.label_trid.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(232, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 42);
            this.label2.TabIndex = 19;
            this.label2.Text = "Zadej masku";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(233, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "ve tvaru (X.X.X.X)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typKalkulačkyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1646, 40);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typKalkulačkyToolStripMenuItem
            // 
            this.typKalkulačkyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matematickáKalkulačkaToolStripMenuItem,
            this.převodMeziSoustavamiToolStripMenuItem});
            this.typKalkulačkyToolStripMenuItem.Name = "typKalkulačkyToolStripMenuItem";
            this.typKalkulačkyToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.typKalkulačkyToolStripMenuItem.Text = "Typ kalkulačky";
            // 
            // matematickáKalkulačkaToolStripMenuItem
            // 
            this.matematickáKalkulačkaToolStripMenuItem.Name = "matematickáKalkulačkaToolStripMenuItem";
            this.matematickáKalkulačkaToolStripMenuItem.Size = new System.Drawing.Size(405, 44);
            this.matematickáKalkulačkaToolStripMenuItem.Text = "Matematická kalkulačka";
            this.matematickáKalkulačkaToolStripMenuItem.Click += new System.EventHandler(this.matematickáKalkulačkaToolStripMenuItem_Click);
            // 
            // převodMeziSoustavamiToolStripMenuItem
            // 
            this.převodMeziSoustavamiToolStripMenuItem.Name = "převodMeziSoustavamiToolStripMenuItem";
            this.převodMeziSoustavamiToolStripMenuItem.Size = new System.Drawing.Size(405, 44);
            this.převodMeziSoustavamiToolStripMenuItem.Text = "Převod mezi soustavami";
            this.převodMeziSoustavamiToolStripMenuItem.Click += new System.EventHandler(this.převodMeziSoustavamiToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1646, 786);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_trid);
            this.Controls.Add(this.label_trida);
            this.Controls.Add(this.label_wild);
            this.Controls.Add(this.label_wildcard);
            this.Controls.Add(this.button_vypocitat);
            this.Controls.Add(this.textBox_maska);
            this.Controls.Add(this.label_broadcast);
            this.Controls.Add(this.label_posledni);
            this.Controls.Add(this.label_prvni);
            this.Controls.Add(this.label_maska);
            this.Controls.Add(this.label_sit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_adresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Výpočet podsítě";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_adresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_sit;
        private System.Windows.Forms.Label label_maska;
        private System.Windows.Forms.Label label_prvni;
        private System.Windows.Forms.Label label_posledni;
        private System.Windows.Forms.Label label_broadcast;
        private System.Windows.Forms.TextBox textBox_maska;
        private System.Windows.Forms.TextBox textbox_adresa_Leave;
        private System.Windows.Forms.Button button_vypocitat;
        private System.Windows.Forms.Label label_wildcard;
        private System.Windows.Forms.Label label_wild;
        private System.Windows.Forms.Label label_trida;
        private System.Windows.Forms.Label label_trid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typKalkulačkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matematickáKalkulačkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem převodMeziSoustavamiToolStripMenuItem;
    }
    }