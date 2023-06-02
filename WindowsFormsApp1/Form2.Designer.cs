namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox_vysledek = new System.Windows.Forms.TextBox();
            this.textBox_vysledek2 = new System.Windows.Forms.TextBox();
            this.textBox_vysledek3 = new System.Windows.Forms.TextBox();
            this.textBox_vysledek4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typKalkulačkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matematickáKalkulačkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výpočetPodsítěToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_vysledek
            // 
            this.textBox_vysledek.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_vysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vysledek.Location = new System.Drawing.Point(45, 231);
            this.textBox_vysledek.Name = "textBox_vysledek";
            this.textBox_vysledek.Size = new System.Drawing.Size(778, 67);
            this.textBox_vysledek.TabIndex = 10;
            this.textBox_vysledek.TextChanged += new System.EventHandler(this.textBox_vysledek_TextChanged);
            // 
            // textBox_vysledek2
            // 
            this.textBox_vysledek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vysledek2.Location = new System.Drawing.Point(840, 231);
            this.textBox_vysledek2.Name = "textBox_vysledek2";
            this.textBox_vysledek2.Size = new System.Drawing.Size(843, 67);
            this.textBox_vysledek2.TabIndex = 11;
            this.textBox_vysledek2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_vysledek3
            // 
            this.textBox_vysledek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vysledek3.Location = new System.Drawing.Point(36, 386);
            this.textBox_vysledek3.Name = "textBox_vysledek3";
            this.textBox_vysledek3.Size = new System.Drawing.Size(787, 67);
            this.textBox_vysledek3.TabIndex = 12;
            this.textBox_vysledek3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_vysledek4
            // 
            this.textBox_vysledek4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_vysledek4.Location = new System.Drawing.Point(840, 386);
            this.textBox_vysledek4.Name = "textBox_vysledek4";
            this.textBox_vysledek4.Size = new System.Drawing.Size(843, 67);
            this.textBox_vysledek4.TabIndex = 11;
            this.textBox_vysledek4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Desítková soustava";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(831, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "Binární soustava";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(36, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 51);
            this.label5.TabIndex = 18;
            this.label5.Text = "Osmičková soustava";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(831, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(492, 51);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hexadecimální soustava";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typKalkulačkyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1711, 40);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typKalkulačkyToolStripMenuItem
            // 
            this.typKalkulačkyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matematickáKalkulačkaToolStripMenuItem,
            this.výpočetPodsítěToolStripMenuItem});
            this.typKalkulačkyToolStripMenuItem.Name = "typKalkulačkyToolStripMenuItem";
            this.typKalkulačkyToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.typKalkulačkyToolStripMenuItem.Text = "Typ kalkulačky";
            // 
            // matematickáKalkulačkaToolStripMenuItem
            // 
            this.matematickáKalkulačkaToolStripMenuItem.Name = "matematickáKalkulačkaToolStripMenuItem";
            this.matematickáKalkulačkaToolStripMenuItem.Size = new System.Drawing.Size(400, 44);
            this.matematickáKalkulačkaToolStripMenuItem.Text = "Matematická kalkulačka";
            this.matematickáKalkulačkaToolStripMenuItem.Click += new System.EventHandler(this.matematickáKalkulačkaToolStripMenuItem_Click);
            // 
            // výpočetPodsítěToolStripMenuItem
            // 
            this.výpočetPodsítěToolStripMenuItem.Name = "výpočetPodsítěToolStripMenuItem";
            this.výpočetPodsítěToolStripMenuItem.Size = new System.Drawing.Size(400, 44);
            this.výpočetPodsítěToolStripMenuItem.Text = "Výpočet podsítě";
            this.výpočetPodsítěToolStripMenuItem.Click += new System.EventHandler(this.výpočetPodsítěToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1711, 704);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_vysledek4);
            this.Controls.Add(this.textBox_vysledek3);
            this.Controls.Add(this.textBox_vysledek2);
            this.Controls.Add(this.textBox_vysledek);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Převody mezi soustavami";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_vysledek;
        private System.Windows.Forms.TextBox textBox_vysledek2;
        private System.Windows.Forms.TextBox textBox_vysledek3;
        private System.Windows.Forms.TextBox textBox_vysledek4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typKalkulačkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matematickáKalkulačkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výpočetPodsítěToolStripMenuItem;
    }
}