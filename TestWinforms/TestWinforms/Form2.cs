using Microsoft.Office.Interop.Excel;
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
using _Excel = Microsoft.Office.Interop.Excel;
namespace TestWinforms
{
    public partial class Form2 : Form
    {
        private _Excel.Application app;
        public Form2()
        {
            InitializeComponent();
            app = new _Excel.Application();
        }

        public void generatetestResults(string outputDirectory, string expectedOutputDirectory)
        {
            //intitialize the excel workbook and worksheet
            string[] outputFiles = Directory.GetFiles(outputDirectory);
            richTextBox1.Text += Environment.NewLine + "================================================================================================";
            foreach (string file in outputFiles)
            {
                // testing one complete workbook inside
                int flag = 1; // success failure flag 1 -> success
                Workbook outputWb = app.Workbooks.Open(file);
                Workbook expectedOutputWb = null;
                string fileName = file.Substring(file.LastIndexOf('\\') + 1, file.LastIndexOf('.') - file.LastIndexOf('\\') - 1);

                
                richTextBox1.Text += Environment.NewLine +  "Evaluation result for " + fileName;

                fileName += "_expected.xlsx";
                string exprectedOutputFilePath = Path.Combine(expectedOutputDirectory, fileName);
                
                try
                {
                    expectedOutputWb = app.Workbooks.Open(exprectedOutputFilePath);
                    int outputWsCount = outputWb.Sheets.Count;
                    int expectedOutputWsCount = expectedOutputWb.Sheets.Count;
                    
                    //check if the number of worksheets in a workbook match
                    if (outputWsCount != expectedOutputWsCount)
                    {
                       // richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                        richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + "Evaluation Result : ** Failure ** " + Environment.NewLine);
                        //richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                        richTextBox1.AppendText(Environment.NewLine + "Comment : ");
                        richTextBox1.AppendText(" Number of worksheets does not match for file ");
                       // richTextBox1.SelectionColor = Color.Black;
                    }
                    else
                    {

                        Worksheet expectedOutputWs;
                        Worksheet outputWs;
                        for (int k = 1; k <= outputWsCount; k++)
                        {
                            flag = 1;
                            //checking a single worksheet here

                            richTextBox1.Text += Environment.NewLine + "Evaluation result for worksheet number " + k ;
                            expectedOutputWs = expectedOutputWb.Worksheets[k];
                            outputWs = outputWb.Worksheets[k];
                            _Excel.Range usedRange_expected = expectedOutputWs.UsedRange;
                            _Excel.Range usedRange_output= outputWs.UsedRange;
                            int rowCount = usedRange_expected.Rows.Count;
                            int colCount = usedRange_expected.Columns.Count;
                            for (int i = 1; i <= rowCount; i++)
                            {
                                for (int j = 1; j <= colCount; j++)
                                {
                                    // Get the cell value
                                    string expectedOutputCellValue = Convert.ToString(expectedOutputWs.Cells[i, j].Value2);
                                    string outputCellValue = Convert.ToString(outputWs.Cells[i, j].Value2);
                                    if(expectedOutputCellValue != outputCellValue)
                                    {
                                        flag = 0;                      
                                        _Excel.Range cell = usedRange_output.Cells[i, j];
                                        cell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                                        outputWb.Save();
                                    }
                                }
                                Console.WriteLine();
                            }
                            if(flag == 1) // no error in the worksheep
                            {
                               // richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                                richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + "Evaluation Result : ** Success ** " + Environment.NewLine);
                               // richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------"+ Environment.NewLine);
                            }
                            else
                            {
                                //richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                                richTextBox1.AppendText(Environment.NewLine + Environment.NewLine + "Evaluation Result : ** Failure ** " + Environment.NewLine);
                                //richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                                richTextBox1.AppendText(Environment.NewLine + "Comment : ");
                                richTextBox1.AppendText("cell value mismatch");
                            }
                            if(outputWsCount >= 2)
                                richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                        }
                    }

                    expectedOutputWb.Close();
                }
                catch (Exception ex)
                {
                    //richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                    richTextBox1.AppendText(Environment.NewLine + Environment.NewLine +"Evaluation Result : ** Failure ** " + Environment.NewLine);
                   // richTextBox1.AppendText(Environment.NewLine + "---------------------------------------------------------------------------------");
                    richTextBox1.AppendText(Environment.NewLine + "Comment : ");
                    richTextBox1.AppendText(" file with the name " + fileName + " Not Found");
                   // richTextBox1.SelectionColor = Color.Black;
                    
                }
                richTextBox1.Text += Environment.NewLine + "================================================================================================";
                outputWb.Save();
                outputWb.Close();
            }

        }
    }
}
