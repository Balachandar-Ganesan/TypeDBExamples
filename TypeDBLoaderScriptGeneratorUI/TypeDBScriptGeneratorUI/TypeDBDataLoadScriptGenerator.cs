using System;
using FileHelpers;
using System.Windows.Forms;
namespace TypeDBScriptGeneratorUI
{
    public partial class frmTypeDBLoadScriptGenerator : Form
    {
        static string strOutput = "";
        static string strQuote = "\"";
        static string strEOC = ";";
        public frmTypeDBLoadScriptGenerator()
        {
            InitializeComponent();
            cmdOk.Click += new System.EventHandler(cmdOk_Click);


        }
        public static string FormatString(string AttributeValue)
        {
            string FormatString = strQuote + AttributeValue + strQuote;
            return FormatString;
        }
        public void cmdOk_Click(object sender,EventArgs e)
        {
            GenerateTQL();
        }

        public void GenerateTQL()
        {
           
            var typedblines = new List<TypeDBLine>();
            strOutput = "";
            string[] allLines = File.ReadAllLines(txtFileName.Text);
            string[] hashtags = txtTags.Text.Split(",");
            string[] colpositions = textBox1.Text.Split(",");
            string[] strFormatter = txtStringFormats.Text.Split(",");
            
            //header row 
            //string[] headerNames = allLines.First().Split(',');
            //iterate data and do something 
            foreach (string line in allLines)
            {
                TypeDBLine typedbline = new TypeDBLine();
                //each row
                string[] columnValues = line.Split(',');
                strOutput = "";
                strOutput = txtTypeSQLTemplate.Text;
                for (int i = 0; i < columnValues.Length; i++)
                {
                   
                    string SearchString = hashtags[i];
                    string ReplaceString = columnValues[i];
                    if (strFormatter[i] == "Y")
                    {
                        ReplaceString = FormatString(ReplaceString);
                    }
                   
                    
                    strOutput =strOutput.Replace(SearchString,ReplaceString);
                    //strOutput = line + strEOC;
                   
                }
               
                typedbline.TQL = strOutput;
                typedblines.Add(typedbline);
            }
            var Writeengine = new FileHelperEngine<TypeDBLine>();
            Writeengine.WriteFile("TypeQLScript.txt", typedblines);
            MessageBox.Show("Script Generated!!!");
        }
    }

    [DelimitedRecord(" ")]

    public class TypeDBLine
    {
        public string TQL;
    }


}