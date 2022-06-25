
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
            this.HandleDataBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Temperatyre = new System.Windows.Forms.Label();
            this.TemperatureV = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.DateV = new System.Windows.Forms.TextBox();
            this.FishHandlerPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilePathBtn = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.HandleFileBtn = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.MinT = new System.Windows.Forms.TextBox();
            this.MinV = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.MaxT = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.MaxV = new System.Windows.Forms.TextBox();
            this.Fish = new System.Windows.Forms.Label();
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
            this.FishHandlerControl.Location = new System.Drawing.Point(13, 250);
            this.FishHandlerControl.Name = "FishHandlerControl";
            this.FishHandlerControl.SelectedIndex = 0;
            this.FishHandlerControl.Size = new System.Drawing.Size(776, 108);
            this.FishHandlerControl.TabIndex = 0;
            // 
            // FishHandlerPage1
            // 
            this.FishHandlerPage1.Controls.Add(this.HandleDataBtn);
            this.FishHandlerPage1.Controls.Add(this.panel1);
            this.FishHandlerPage1.Location = new System.Drawing.Point(4, 24);
            this.FishHandlerPage1.Name = "FishHandlerPage1";
            this.FishHandlerPage1.Padding = new System.Windows.Forms.Padding(3);
            this.FishHandlerPage1.Size = new System.Drawing.Size(768, 80);
            this.FishHandlerPage1.TabIndex = 0;
            this.FishHandlerPage1.Text = "DataHandler";
            this.FishHandlerPage1.UseVisualStyleBackColor = true;
            // 
            // HandleDataBtn
            // 
            this.HandleDataBtn.Location = new System.Drawing.Point(687, 42);
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
            this.panel1.Controls.Add(this.Temperatyre);
            this.panel1.Controls.Add(this.TemperatureV);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.DateV);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 66);
            this.panel1.TabIndex = 0;
            // 
            // Temperatyre
            // 
            this.Temperatyre.AutoSize = true;
            this.Temperatyre.Location = new System.Drawing.Point(12, 39);
            this.Temperatyre.Name = "Temperatyre";
            this.Temperatyre.Size = new System.Drawing.Size(73, 15);
            this.Temperatyre.TabIndex = 9;
            this.Temperatyre.Text = "Temperature";
            // 
            // TemperatureV
            // 
            this.TemperatureV.Location = new System.Drawing.Point(99, 36);
            this.TemperatureV.Name = "TemperatureV";
            this.TemperatureV.Size = new System.Drawing.Size(213, 23);
            this.TemperatureV.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(54, 10);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 15);
            this.Date.TabIndex = 7;
            this.Date.Text = "Date";
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
            this.FishHandlerPage2.Controls.Add(this.panel2);
            this.FishHandlerPage2.Controls.Add(this.HandleFileBtn);
            this.FishHandlerPage2.Location = new System.Drawing.Point(4, 24);
            this.FishHandlerPage2.Name = "FishHandlerPage2";
            this.FishHandlerPage2.Padding = new System.Windows.Forms.Padding(3);
            this.FishHandlerPage2.Size = new System.Drawing.Size(768, 80);
            this.FishHandlerPage2.TabIndex = 1;
            this.FishHandlerPage2.Text = "FileHandler";
            this.FishHandlerPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.FilePathBtn);
            this.panel2.Controls.Add(this.Text);
            this.panel2.Controls.Add(this.FilePath);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 66);
            this.panel2.TabIndex = 5;
            // 
            // FilePathBtn
            // 
            this.FilePathBtn.Location = new System.Drawing.Point(319, 28);
            this.FilePathBtn.Name = "FilePathBtn";
            this.FilePathBtn.Size = new System.Drawing.Size(75, 23);
            this.FilePathBtn.TabIndex = 6;
            this.FilePathBtn.Text = "Choose file";
            this.FilePathBtn.UseVisualStyleBackColor = true;
            this.FilePathBtn.Click += new System.EventHandler(this.FilePathBtn_Click);
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(12, 31);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(52, 15);
            this.Text.TabIndex = 9;
            this.Text.Text = "File path";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(81, 28);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(213, 23);
            this.FilePath.TabIndex = 8;
            // 
            // HandleFileBtn
            // 
            this.HandleFileBtn.Location = new System.Drawing.Point(663, 37);
            this.HandleFileBtn.Name = "HandleFileBtn";
            this.HandleFileBtn.Size = new System.Drawing.Size(75, 23);
            this.HandleFileBtn.TabIndex = 4;
            this.HandleFileBtn.Text = "handle";
            this.HandleFileBtn.UseVisualStyleBackColor = true;
            this.HandleFileBtn.Click += new System.EventHandler(this.HandleFileBtn_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(246, 37);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(538, 196);
            this.InfoTextBox.TabIndex = 2;
            this.InfoTextBox.Text = "";
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
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(137, 107);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(33, 15);
            this.Time.TabIndex = 25;
            this.Time.Text = "Time";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(57, 107);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(73, 15);
            this.Temperature.TabIndex = 24;
            this.Temperature.Text = "Temperature";
            // 
            // MaxT
            // 
            this.MaxT.Location = new System.Drawing.Point(136, 125);
            this.MaxT.Name = "MaxT";
            this.MaxT.Size = new System.Drawing.Size(33, 23);
            this.MaxT.TabIndex = 23;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(13, 157);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(28, 15);
            this.min.TabIndex = 22;
            this.min.Text = "min";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(13, 128);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(30, 15);
            this.max.TabIndex = 21;
            this.max.Text = "max";
            // 
            // MaxV
            // 
            this.MaxV.Location = new System.Drawing.Point(75, 125);
            this.MaxV.Name = "MaxV";
            this.MaxV.Size = new System.Drawing.Size(33, 23);
            this.MaxV.TabIndex = 20;
            // 
            // Fish
            // 
            this.Fish.AutoSize = true;
            this.Fish.Location = new System.Drawing.Point(12, 84);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(28, 15);
            this.Fish.TabIndex = 19;
            this.Fish.Text = "Fish";
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
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.MinT);
            this.Controls.Add(this.MinV);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.MaxT);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.MaxV);
            this.Controls.Add(this.Fish);
            this.Controls.Add(this.FishV);
            this.Controls.Add(this.FishHandlerControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.Label Temperatyre;
        private System.Windows.Forms.TextBox TemperatureV;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox DateV;
        private System.Windows.Forms.TabPage FishHandlerPage2;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Button HandleDataBtn;
        private System.Windows.Forms.Button HandleFileBtn;
        private System.Windows.Forms.TextBox MinT;
        private System.Windows.Forms.TextBox MinV;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.TextBox MaxT;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.TextBox MaxV;
        private System.Windows.Forms.Label Fish;
        private System.Windows.Forms.TextBox FishV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private Panel panel2;
        private Button FilePathBtn;
        private Label Text;
        private TextBox FilePath;
    }
}

