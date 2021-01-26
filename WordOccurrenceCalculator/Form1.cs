using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordOccurrenceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String inputText = textBox1.Text.Trim();
            String[] createSplitString = inputText.Split(' ');

            ArrayList inputList = new ArrayList();
            for (int i = 0; i < createSplitString.Length; i++)
                inputList.Add(createSplitString[i]);

            WordOccurrence[] obj = WordCalculator.CalculateOccurrences(inputList);
            String outputString = "";

            for (int i = 0; i < obj.Length; i++)
            {
                string countResult = obj[i].Word +" = " + obj[i].Count + "\n";
                outputString = outputString + countResult;
            }
            label1.Text = outputString;
        }
    }
}
