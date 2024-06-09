using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinforms
{
    public partial class Form1 : Form
    {
        private List<string> inputFilenames;
        private string outputDirectoryPath = "";
        public Form1()
        {
            InitializeComponent();
            inputFilenames = new List<string>();
            //initialize connection with sql server
            
        }

        private void selectInputDir(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                textBox1.Text = dialog.SelectedPath;
            }

            string[] files = Directory.GetFiles(textBox1.Text);
            foreach(var file in files)
            {
                string filename = file.Substring(file.LastIndexOf('\\') + 1);
                string filetype = file.Substring(file.LastIndexOf('.') + 1);
                if (filetype == "xlsx")
                {
                    listedFiles.Text += filename + Environment.NewLine;
                    inputFilenames.Add(file);
                }
            }
        }

        private void selectOutputDir(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = dialog.SelectedPath;
                outputDirectoryPath = dialog.SelectedPath;
            }
            
        }

        private void selectExpectedOutputDir(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox3.Text = dialog.SelectedPath;
            }
        }

        private void generateOutput(object sender, EventArgs e)
        {
            API obj = new API();
            obj.generateOutputFiles(inputFilenames, outputDirectoryPath);
        }

        private void testAPI(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();            
            form2.generatetestResults(textBox2.Text, textBox3.Text);
        }
    }
}
