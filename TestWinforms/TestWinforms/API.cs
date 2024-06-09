using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace TestWinforms
{
    internal class API
    {
        _Application app;

        public API() 
        {
           app  = new _Excel.Application();
        }
        

        public void generateOutputFiles(List<String> inputFilenames, string outputDirectory)
        {
            //intitialize the excel workbook and worksheet
            foreach(var file in inputFilenames)
            {
                Workbook inputWb = app.Workbooks.Open(file);
                
                //create a new WorkBook for output
                Workbook outputWb = app.Workbooks.Add();

                string valInCell = "";
                
                int worsheetCount = inputWb.Sheets.Count;
                int k;
                string dirPath = outputDirectory + "\\";
                string fileName = file.Substring(file.LastIndexOf('\\') + 1, file.LastIndexOf('.') - file.LastIndexOf('\\') - 1);
                fileName = fileName + "_output.xlsx";
                outputWb.SaveAs(dirPath + fileName);
                Worksheet inputWs;
                Worksheet outputWs;
                for ( k = 1; k <= worsheetCount; k++)
                {
                    inputWs = inputWb.Worksheets[k];
                    outputWs = outputWb.Worksheets[k];
                    int i = 1;
                    int j = 1;
                    do
                    {
                        valInCell = Convert.ToString(inputWs.Cells[i, j].Value2);
                        int val = 0;
                        if (valInCell != null)
                        {
                            val = int.Parse(valInCell);
                            outputWs.Cells[i, j] = val * 2;
                        }
                        i++;
                    } while (valInCell != null);
                    outputWb.Save();
                    int outputSheetCount = outputWb.Sheets.Count;
                    Worksheet lastWorksheet = outputWb.Sheets[outputWb.Sheets.Count];
                    outputWb.Sheets.Add(After: lastWorksheet);
                    outputWb.Save();

                }
                Worksheet lastWorksheet2 = outputWb.Sheets[outputWb.Sheets.Count];
                lastWorksheet2.Delete();
                outputWb.Save();
                inputWb.Close();
                outputWb.Close();
            }
            
        }
    }
}
