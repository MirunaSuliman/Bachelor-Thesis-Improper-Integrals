namespace Interfata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            f_in = new TextBox();
            label4 = new Label();
            var_der = new TextBox();
            p = new PictureBox();
            camp_a = new TextBox();
            camp_b = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            val_param = new TextBox();
            param = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            simp_er = new TextBox();
            simp_aprox = new TextBox();
            trap_er = new TextBox();
            trap_aprox = new TextBox();
            drept_er = new TextBox();
            drept_aprox = new TextBox();
            label16 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            f_derivata_out = new TextBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            gammaToolStripMenuItem = new ToolStripMenuItem();
            gaussToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(244, 317);
            button1.Name = "button1";
            button1.Size = new Size(193, 64);
            button1.TabIndex = 0;
            button1.Text = "Calculeaza";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // f_in
            // 
            f_in.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            f_in.Location = new Point(142, 104);
            f_in.Multiline = true;
            f_in.Name = "f_in";
            f_in.Size = new Size(338, 35);
            f_in.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("CMU Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(516, 183);
            label4.Name = "label4";
            label4.Size = new Size(0, 27);
            label4.TabIndex = 7;
            // 
            // var_der
            // 
            var_der.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            var_der.Location = new Point(511, 104);
            var_der.Multiline = true;
            var_der.Name = "var_der";
            var_der.Size = new Size(47, 35);
            var_der.TabIndex = 9;
            // 
            // p
            // 
            p.BorderStyle = BorderStyle.Fixed3D;
            p.Location = new Point(14, 41);
            p.Margin = new Padding(4);
            p.Name = "p";
            p.Size = new Size(499, 516);
            p.TabIndex = 10;
            p.TabStop = false;
            p.Paint += p_Paint;
            // 
            // camp_a
            // 
            camp_a.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            camp_a.Location = new Point(76, 166);
            camp_a.Multiline = true;
            camp_a.Name = "camp_a";
            camp_a.Size = new Size(70, 30);
            camp_a.TabIndex = 11;
            // 
            // camp_b
            // 
            camp_b.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            camp_b.Location = new Point(76, 50);
            camp_b.Multiline = true;
            camp_b.Name = "camp_b";
            camp_b.Size = new Size(70, 30);
            camp_b.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(camp_a);
            groupBox1.Controls.Add(camp_b);
            groupBox1.Controls.Add(val_param);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(var_der);
            groupBox1.Controls.Add(param);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(f_in);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("CMU Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(699, 403);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduceti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("CMU Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(479, 99);
            label1.Name = "label1";
            label1.Size = new Size(36, 40);
            label1.TabIndex = 16;
            label1.Text = "d";
            // 
            // val_param
            // 
            val_param.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            val_param.Location = new Point(434, 244);
            val_param.Multiline = true;
            val_param.Name = "val_param";
            val_param.Size = new Size(85, 35);
            val_param.TabIndex = 13;
            // 
            // param
            // 
            param.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            param.Location = new Point(434, 185);
            param.Multiline = true;
            param.Name = "param";
            param.Size = new Size(85, 35);
            param.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(196, 235);
            label8.Name = "label8";
            label8.Size = new Size(205, 54);
            label8.TabIndex = 11;
            label8.Text = "Valoarea numerica \r\n   a parametrului";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.integral;
            pictureBox1.Location = new Point(44, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 116);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(234, 185);
            label7.Name = "label7";
            label7.Size = new Size(125, 27);
            label7.TabIndex = 10;
            label7.Text = "Parametrul";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(simp_er);
            groupBox2.Controls.Add(simp_aprox);
            groupBox2.Controls.Add(trap_er);
            groupBox2.Controls.Add(trap_aprox);
            groupBox2.Controls.Add(drept_er);
            groupBox2.Controls.Add(drept_aprox);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("CMU Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 453);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 338);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Valoarea integralei";
            // 
            // simp_er
            // 
            simp_er.Font = new Font("CMU Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            simp_er.Location = new Point(443, 262);
            simp_er.Multiline = true;
            simp_er.Name = "simp_er";
            simp_er.Size = new Size(208, 35);
            simp_er.TabIndex = 21;
            // 
            // simp_aprox
            // 
            simp_aprox.Font = new Font("CMU Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            simp_aprox.Location = new Point(208, 262);
            simp_aprox.Multiline = true;
            simp_aprox.Name = "simp_aprox";
            simp_aprox.Size = new Size(208, 35);
            simp_aprox.TabIndex = 20;
            // 
            // trap_er
            // 
            trap_er.Font = new Font("CMU Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            trap_er.Location = new Point(443, 182);
            trap_er.Multiline = true;
            trap_er.Name = "trap_er";
            trap_er.Size = new Size(208, 35);
            trap_er.TabIndex = 19;
            // 
            // trap_aprox
            // 
            trap_aprox.Font = new Font("CMU Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            trap_aprox.Location = new Point(208, 182);
            trap_aprox.Multiline = true;
            trap_aprox.Name = "trap_aprox";
            trap_aprox.Size = new Size(208, 35);
            trap_aprox.TabIndex = 18;
            // 
            // drept_er
            // 
            drept_er.Font = new Font("CMU Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            drept_er.Location = new Point(443, 99);
            drept_er.Multiline = true;
            drept_er.Name = "drept_er";
            drept_er.Size = new Size(208, 35);
            drept_er.TabIndex = 17;
            // 
            // drept_aprox
            // 
            drept_aprox.Font = new Font("CMU Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            drept_aprox.Location = new Point(208, 99);
            drept_aprox.Multiline = true;
            drept_aprox.Name = "drept_aprox";
            drept_aprox.Size = new Size(208, 35);
            drept_aprox.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(485, 30);
            label16.Name = "label16";
            label16.Size = new Size(108, 54);
            label16.TabIndex = 13;
            label16.Text = "estimarea\r\nerorii";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(252, 30);
            label13.Name = "label13";
            label13.Size = new Size(135, 54);
            label13.TabIndex = 10;
            label13.Text = "aproximarea\r\nvalorii";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(28, 172);
            label12.Name = "label12";
            label12.Size = new Size(140, 54);
            label12.TabIndex = 9;
            label12.Text = "Prin metoda\r\ntrapezelor\r\n";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 252);
            label11.Name = "label11";
            label11.Size = new Size(140, 54);
            label11.TabIndex = 8;
            label11.Text = "Prin metoda\r\nlui Simpson\r\n";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 89);
            label10.Name = "label10";
            label10.Size = new Size(162, 54);
            label10.TabIndex = 7;
            label10.Text = "Prin metoda\r\ndreptunghiului\r\n";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(f_derivata_out);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("CMU Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(726, 627);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 164);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Derivata functiei ";
            // 
            // f_derivata_out
            // 
            f_derivata_out.Font = new Font("CMU Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            f_derivata_out.Location = new Point(78, 53);
            f_derivata_out.Multiline = true;
            f_derivata_out.Name = "f_derivata_out";
            f_derivata_out.Size = new Size(388, 70);
            f_derivata_out.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 50);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(p);
            groupBox4.Font = new Font("CMU Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox4.Location = new Point(726, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(529, 577);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Graficul functiei";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1270, 31);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "Exemple";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = SystemColors.GradientActiveCaption;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { gammaToolStripMenuItem, gaussToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("CMU Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(97, 27);
            toolStripMenuItem1.Text = "Exemple";
            // 
            // gammaToolStripMenuItem
            // 
            gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            gammaToolStripMenuItem.Size = new Size(224, 28);
            gammaToolStripMenuItem.Text = "Gamma";
            gammaToolStripMenuItem.Click += gammaToolStripMenuItem_Click;
            // 
            // gaussToolStripMenuItem
            // 
            gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
            gaussToolStripMenuItem.Size = new Size(224, 28);
            gaussToolStripMenuItem.Text = "Gauss";
            gaussToolStripMenuItem.Click += gaussToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1270, 786);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Aplicatie integrale cu parametru";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox f_in;
        private Label label4;
        private TextBox var_der;
        private PictureBox p;
        private TextBox camp_a;
        private TextBox camp_b;
        private GroupBox groupBox1;
        private TextBox val_param;
        private TextBox param;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label label16;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox simp_er;
        private TextBox simp_aprox;
        private TextBox trap_er;
        private TextBox trap_aprox;
        private TextBox drept_er;
        private TextBox drept_aprox;
        private GroupBox groupBox3;
        private TextBox f_derivata_out;
        private Label label2;
        private GroupBox groupBox4;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem gammaToolStripMenuItem;
        private ToolStripMenuItem gaussToolStripMenuItem;
    }
}