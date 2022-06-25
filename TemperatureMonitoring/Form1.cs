using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HandleDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FishInfo fish = new FishInfo(FishV.Text, MaxV.Text, MaxT.Text, MinV.Text, MinT.Text, DateV.Text, TemperatureV.Text);
                InfoTextBox.Text = fish.Check();
                if(InfoTextBox.Text.Length > 15)
                {
                    MessageBox.Show("нарушении условий хранения рыбы");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Wrong data");
            }
        }

        private void HandleFileBtn_Click(object sender, EventArgs e)
        {
            string dateData = "";
            string temperatureData = "";
            string str;
            string path = FilePath.Text; 

            if(path == null)
            {
                MessageBox.Show("Wrong path");
                return;
            }

            using (StreamReader reader = new StreamReader(path, false))
            {
                str = reader.ReadLine();
                while (str != null)
                {
                    try
                    {
                        if(str.Length < 18)
                        {
                            dateData = str;
                        }
                        else
                        {
                            temperatureData = str;
                        }
                    }
                    catch
                    {
                        str = reader.ReadLine();
                    }
                    str = reader.ReadLine();
                }
                FishInfo fish = new FishInfo(FishV.Text, MaxV.Text, MaxT.Text, MinV.Text, MinT.Text, dateData, temperatureData);
                InfoTextBox.Text = fish.Check();
                if (InfoTextBox.Text.Length > 15)
                {
                    MessageBox.Show("нарушении условий хранения рыбы");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                path = SaveFile.FileName;
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                string fishInfo = ($"Fish: {FishV.Text};\nmax temperature: {MaxV.Text}, {MaxT.Text} minutes;\nmin temperature: {MinV.Text}, {MinT.Text} minutes;\n{InfoTextBox.Text}");
                writer.WriteLine(fishInfo);
            }
        }

        private void FilePathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = OpenFile.FileName;
            }
        }
    }
}
