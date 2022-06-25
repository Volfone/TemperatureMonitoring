
namespace TemperatureMonitoring
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.FishHandlerControl = new System.Windows.Forms.TabControl();
            this.FishHandlerPage1 = new System.Windows.Forms.TabPage();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.HandleDataBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinT = new System.Windows.Forms.TextBox();
            this.MinV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TemperatureV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FishV = new System.Windows.Forms.TextBox();
            this.FishHandlerPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.HandleFileBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.FilePathV = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.FishHandlerControl.SuspendLayout();
            this.FishHandlerPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FishHandlerPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FishHandlerControl
            // 
            this.FishHandlerControl.Controls.Add(this.FishHandlerPage1);
            this.FishHandlerControl.Controls.Add(this.FishHandlerPage2);
            this.FishHandlerControl.Location = new System.Drawing.Point(12, 12);
            this.FishHandlerControl.Name = "FishHandlerControl";
            this.FishHandlerControl.SelectedIndex = 0;
            this.FishHandlerControl.Size = new System.Drawing.Size(776, 426);
            this.FishHandlerControl.TabIndex = 0;
            // 
            // FishHandlerPage1
            // 
            this.FishHandlerPage1.Controls.Add(this.InfoTextBox);
            this.FishHandlerPage1.Controls.Add(this.HandleDataBtn);
            this.FishHandlerPage1.Controls.Add(this.panel1);
            this.FishHandlerPage1.Location = new System.Drawing.Point(4, 24);
            this.FishHandlerPage1.Name = "FishHandlerPage1";
            this.FishHandlerPage1.Padding = new System.Windows.Forms.Padding(3);
            this.FishHandlerPage1.Size = new System.Drawing.Size(768, 398);
            this.FishHandlerPage1.TabIndex = 0;
            this.FishHandlerPage1.Text = "DataHandler";
            this.FishHandlerPage1.UseVisualStyleBackColor = true;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(6, 196);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(616, 196);
            this.InfoTextBox.TabIndex = 2;
            this.InfoTextBox.Text = "";
            // 
            // HandleDataBtn
            // 
            this.HandleDataBtn.Location = new System.Drawing.Point(687, 369);
            this.HandleDataBtn.Name = "HandleDataBtn";
            this.HandleDataBtn.Size = new System.Drawing.Size(75, 23);
            this.HandleDataBtn.TabIndex = 1;
            this.HandleDataBtn.Text = "handle";
            this.HandleDataBtn.UseVisualStyleBackColor = true;
            this.HandleDataBtn.Click += new System.EventHandler(this.HandleDataBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.MinT);
            this.panel1.Controls.Add(this.MinV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MaxT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TemperatureV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DateV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MaxV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FishV);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 183);
            this.panel1.TabIndex = 0;
            // 
            // MinT
            // 
            this.MinT.Location = new System.Drawing.Point(181, 83);
            this.MinT.Name = "MinT";
            this.MinT.Size = new System.Drawing.Size(33, 23);
            this.MinT.TabIndex = 17;
            // 
            // MinV
            // 
            this.MinV.Location = new System.Drawing.Point(119, 83);
            this.MinV.Name = "MinV";
            this.MinV.Size = new System.Drawing.Size(33, 23);
            this.MinV.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Temperature";
            // 
            // MaxT
            // 
            this.MaxT.Location = new System.Drawing.Point(180, 54);
            this.MaxT.Name = "MaxT";
            this.MaxT.Size = new System.Drawing.Size(33, 23);
            this.MaxT.TabIndex = 10;
            this.MaxT.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperature";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TemperatureV
            // 
            this.TemperatureV.Location = new System.Drawing.Point(101, 141);
            this.TemperatureV.Name = "TemperatureV";
            this.TemperatureV.Size = new System.Drawing.Size(213, 23);
            this.TemperatureV.TabIndex = 8;
            this.TemperatureV.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DateV
            // 
            this.DateV.Location = new System.Drawing.Point(101, 112);
            this.DateV.Name = "DateV";
            this.DateV.Size = new System.Drawing.Size(113, 23);
            this.DateV.TabIndex = 6;
            this.DateV.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "max";
            // 
            // MaxV
            // 
            this.MaxV.Location = new System.Drawing.Point(119, 54);
            this.MaxV.Name = "MaxV";
            this.MaxV.Size = new System.Drawing.Size(33, 23);
            this.MaxV.TabIndex = 2;
            this.MaxV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fish";
            // 
            // FishV
            // 
            this.FishV.Location = new System.Drawing.Point(101, 10);
            this.FishV.Name = "FishV";
            this.FishV.Size = new System.Drawing.Size(113, 23);
            this.FishV.TabIndex = 0;
            // 
            // FishHandlerPage2
            // 
            this.FishHandlerPage2.Controls.Add(this.richTextBox2);
            this.FishHandlerPage2.Controls.Add(this.HandleFileBtn);
            this.FishHandlerPage2.Controls.Add(this.panel2);
            this.FishHandlerPage2.Location = new System.Drawing.Point(4, 24);
            this.FishHandlerPage2.Name = "FishHandlerPage2";
            this.FishHandlerPage2.Padding = new System.Windows.Forms.Padding(3);
            this.FishHandlerPage2.Size = new System.Drawing.Size(768, 398);
            this.FishHandlerPage2.TabIndex = 1;
            this.FishHandlerPage2.Text = "FileHandler";
            this.FishHandlerPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 196);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(331, 196);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // HandleFileBtn
            // 
            this.HandleFileBtn.Location = new System.Drawing.Point(687, 369);
            this.HandleFileBtn.Name = "HandleFileBtn";
            this.HandleFileBtn.Size = new System.Drawing.Size(75, 23);
            this.HandleFileBtn.TabIndex = 4;
            this.HandleFileBtn.Text = "handle";
            this.HandleFileBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.FilePathV);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 183);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "File";
            // 
            // FilePathV
            // 
            this.FilePathV.Location = new System.Drawing.Point(101, 122);
            this.FilePathV.Name = "FilePathV";
            this.FilePathV.Size = new System.Drawing.Size(113, 23);
            this.FilePathV.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 23);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 23);
            this.textBox2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Temperature";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 23);
            this.textBox3.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "max";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(119, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(33, 23);
            this.textBox6.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fish";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(101, 10);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 23);
            this.textBox7.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FishHandlerControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FishHandlerControl.ResumeLayout(false);
            this.FishHandlerPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FishHandlerPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TabControl FishHandlerControl;
        private System.Windows.Forms.TabPage FishHandlerPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TemperatureV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DateV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FishV;
        private System.Windows.Forms.TabPage FishHandlerPage2;
        private System.Windows.Forms.TextBox MaxT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button HandleDataBtn;
        private System.Windows.Forms.TextBox MinT;
        private System.Windows.Forms.TextBox MinV;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button HandleFileBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FilePathV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox7;
    }
}

