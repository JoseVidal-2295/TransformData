using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformData
{
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            string input = "";
            string outPut = "";

            input = textInput.Text;

            
            string pattern = textCondition.Text;  //"name=\\\"(.*?)\\\"";


            //Verificamos cual tipo de condicion vamos a utilizar

            if (rbCondition1.Checked == true)
            {
                pattern = textCondition.Text;
            }
            else if(rbCondition2.Checked == true)
            {
                pattern = textCondition2.Text;
            }
            else if (rbCondition3.Checked == true)
            {
                pattern = textCondition3.Text;
            }
            else if (rbCondition4.Checked == true)
            {
                pattern = textCondition4.Text;
            }
            //if (chkUseCondition.Checked == true)
            //{
            //    pattern = textCondition2.Text;
            //}

            try
            {

                MatchCollection matches = Regex.Matches(input, pattern);

                if (matches.Count < 1)
                {
                    MessageBox.Show($"No se encontraron coincidencias con la condición especificada: {pattern}", "Transformar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                foreach (Match match in matches)
                {
                    if (outPut == "")
                    {
                        outPut = match.Groups[1].Value.Replace("\n", "").Replace("\r", "").Trim();
                    }
                    else
                    {
                        outPut = outPut + Environment.NewLine + match.Groups[1].Value.Replace("\n", "").Replace("\r", "").Trim();
                    }

                }

                textOutPut.Text = outPut;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error en la condición digitada: {pattern}", "Transformar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textCondition.Text = "name=\\\"(.*?)\\\"";
            textCondition2.Text = @"ElementName\s*=\s*""(\w+)""";
            textCondition3.Text = @"<([^/<>]+)>";
            textCondition4.Text = "<([^>]*)>";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textInput.Clear();
            textOutPut.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkUseCondition_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
