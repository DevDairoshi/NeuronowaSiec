using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            ChooseFileDialog.InitialDirectory = "c:\\";
            ChooseFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ChooseFileDialog.FilterIndex = 2;
            ChooseFileDialog.RestoreDirectory = true;

            var path = string.Empty;
            var pathFull = string.Empty;
            var content = string.Empty;

            if (ChooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFull = ChooseFileDialog.FileName;
                path = ChooseFileDialog.SafeFileName;
                lChoosenFile.Text = $"File: {path}";

                var fileStream = ChooseFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    content = reader.ReadToEnd();
                }
            }
            else throw new FormatException();

            content.Replace(",", ".");
            
            NeuralNetwork.Create(pathFull, content);

            lNetwork.Text = NeuralNetwork.ToString();
        }

        private void bProceed_Click(object sender, EventArgs e)
        {
            var strInputs = tbInput.Text.Split(' ');

            foreach (var val in strInputs)
            {
                NeuralNetwork.Inputs.Add(double.Parse(val));
            }

            NeuralNetwork.Proceed();
            
            var str = new StringBuilder();

            foreach (var output in NeuralNetwork.Outputs)
            {
                str.Append($"{output.ToString()}\n");
            }

            lOutput.Text = str.ToString();
        }
    }
}
