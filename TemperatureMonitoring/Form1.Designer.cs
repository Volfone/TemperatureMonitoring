
using System.Windows.Forms;

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
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.FishHandlerControl = new System.Windows.Forms.TabControl();
            this.FishHandlerPage1 = new System.Windows.Forms.TabPage();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.HandleDataBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TemperatureV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateV = new System.Windows.Forms.TextBox();
            this.FishHandlerPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.HandleFileBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.FilePathV = new System.Windows.Forms.TextBox();
            this.MinT = new System.Windows.Forms.TextBox();
            this.MinV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FishV = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FishHandlerControl.SuspendLayout();
            this.FishHandlerPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FishHandlerPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FishHandlerControl
            // 
            this.FishHandlerControl.Controls.Add(this.FishHandlerPage1);
            this.FishHandlerControl.Controls.Add(this.FishHandlerPage2);
            this.FishHandlerControl.Location = new System.Drawing.Point(12, 215);
            this.FishHandlerControl.Name = "FishHandlerControl";
            this.FishHandlerControl.SelectedIndex = 0;
            this.FishHandlerControl.Size = new System.Drawing.Size(776, 308);
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
            this.FishHandlerPage1.Size = new System.Drawing.Size(768, 280);
            this.FishHandlerPage1.TabIndex = 0;
            this.FishHandlerPage1.Text = "DataHandler";
            this.FishHandlerPage1.UseVisualStyleBackColor = true;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(5, 78);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(616, 196);
            this.InfoTextBox.TabIndex = 2;
            this.InfoTextBox.Text = "";
            // 
            // HandleDataBtn
            // 
            this.HandleDataBtn.Location = new System.Drawing.Point(686, 251);
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TemperatureV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DateV);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 66);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperature";
            // 
            // TemperatureV
            // 
            this.TemperatureV.Location = new System.Drawing.Point(99, 36);
            this.TemperatureV.Name = "TemperatureV";
            this.TemperatureV.Size = new System.Drawing.Size(213, 23);
            this.TemperatureV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // DateV
            // 
            this.DateV.Location = new System.Drawing.Point(99, 7);
            this.DateV.Name = "DateV";
            this.DateV.Size = new System.Drawing.Size(113, 23);
            this.DateV.TabIndex = 6;
            // 
            // FishHandlerPage2
            // 
            this.FishHandlerPage2.Controls.Add(this.richTextBox2);
            this.FishHandlerPage2.Controls.Add(this.HandleFileBtn);
            this.FishHandlerPage2.Controls.Add(this.panel2);
            this.FishHandlerPage2.Location = new System.Drawing.Point(4, 24);
            this.FishHandlerPage2.Name = "FishHandlerPage2";
            this.FishHandlerPage2.Padding = new System.Windows.Forms.Padding(3);
            this.FishHandlerPage2.Size = new System.Drawing.Size(768, 280);
            this.FishHandlerPage2.TabIndex = 1;
            this.FishHandlerPage2.Text = "FileHandler";
            this.FishHandlerPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 39);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(629, 235);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // HandleFileBtn
            // 
            this.HandleFileBtn.Location = new System.Drawing.Point(687, 251);
            this.HandleFileBtn.Name = "HandleFileBtn";
            this.HandleFileBtn.Size = new System.Drawing.Size(75, 23);
            this.HandleFileBtn.TabIndex = 4;
            this.HandleFileBtn.Text = "handle";
            this.HandleFileBtn.UseVisualStyleBackColor = true;
            this.HandleFileBtn.Click += new System.EventHandler(this.HandleFileBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.FilePathV);
            this.panel2.Location = new System.Drawing.Point(7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 28);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "File";
            // 
            // FilePathV
            // 
            this.FilePathV.Location = new System.Drawing.Point(73, 3);
            this.FilePathV.Name = "FilePathV";
            this.FilePathV.Size = new System.Drawing.Size(113, 23);
            this.FilePathV.TabIndex = 18;
            // 
            // MinT
            // 
            this.MinT.Location = new System.Drawing.Point(137, 154);
            this.MinT.Name = "MinT";
            this.MinT.Size = new System.Drawing.Size(33, 23);
            this.MinT.TabIndex = 27;
            // 
            // MinV
            // 
            this.MinV.Location = new System.Drawing.Point(75, 154);
            this.MinV.Name = "MinV";
            this.MinV.Size = new System.Drawing.Size(33, 23);
            this.MinV.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Temperature";
            // 
            // MaxT
            // 
            this.MaxT.Location = new System.Drawing.Point(136, 125);
            this.MaxT.Name = "MaxT";
            this.MaxT.Size = new System.Drawing.Size(33, 23);
            this.MaxT.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "max";
            // 
            // MaxV
            // 
            this.MaxV.Location = new System.Drawing.Point(75, 125);
            this.MaxV.Name = "MaxV";
            this.MaxV.Size = new System.Drawing.Size(33, 23);
            this.MaxV.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fish";
            // 
            // FishV
            // 
            this.FishV.Location = new System.Drawing.Point(57, 81);
            this.FishV.Name = "FishV";
            this.FishV.Size = new System.Drawing.Size(113, 23);
            this.FishV.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.MinT);
            this.Controls.Add(this.MinV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FishV);
            this.Controls.Add(this.FishHandlerControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.TabControl FishHandlerControl;
        private System.Windows.Forms.TabPage FishHandlerPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TemperatureV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DateV;
        private System.Windows.Forms.TabPage FishHandlerPage2;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button HandleDataBtn;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button HandleFileBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FilePathV;
        private System.Windows.Forms.TextBox MinT;
        private System.Windows.Forms.TextBox MinV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FishV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

