using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public static class NeuralNetwork
    {
        public static string Test { get; set; }
        public static string Path { get; set; }
        public static string LoadedContent { get; set; }
        public static List<double> Inputs = new List<double>();
        public static List<List<Neuron>> Network = new List<List<Neuron>>();
        public static List<double> Outputs = new List<double>();

        public static void Create(string path, string content)
        {
            Clear();
            Path = path;
            LoadedContent = content;

            var splitContent = LoadedContent.Split(new char[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitContent.Length; i++)
            {
                Network.Add(new List<Neuron>());
            }

            //Test = splitContent.Length;

            for (int i = 0; i < splitContent.Length; i++)
            {
                var strLayer = splitContent[i];
                var strNeurons = strLayer.Split('\t');

                foreach (var strNeuron in strNeurons)
                {
                    var values = new List<double>();
                    var split = strNeuron.Split(' ');
                    foreach (var str in split)
                    {
                        values.Add(double.Parse(str));
                    }
                    Network[i].Add(new Neuron(values.ToArray()));
                }
            }
        }

        public static void Proceed()
        {
            //inputs
            for (int i = 0; i < Network[0].Count; i++)
            {
                var val = 0.0d;
                val += Network[0][i].Beta * Network[0][i].Weights[0];

                for (int j = 0; j < Inputs.Count; j++)
                {
                    val += Inputs[j] * Network[0][i].Weights[j + 1];
                }

                Network[0][i].Value = val;
                Network[0][i].Output = CalculateNeuronOutput(Network[0][i].Beta, Network[0][i].Value);
            }

            //the rest
            for (int i = 1; i < Network.Count; i++)
            {
                for (int j = 0; j < Network[i].Count; j++)
                {
                    var val = 0.0d;
                    val += Network[i][j].Beta * Network[i][j].Weights[0];

                    for (int k = 0; k < Network[i - 1].Count; k++)
                    {
                        val += Network[i - 1][k].Output * Network[i][j].Weights[k + 1];
                    }

                    Network[i][j].Value = val;
                    Network[i][j].Output = CalculateNeuronOutput(Network[i][j].Beta, Network[i][j].Value);
                }
            }

            for (int i = 0; i < Network[Network.Count - 1].Count; i++)
            {
                Outputs.Add(Network[Network.Count - 1][i].Output);
            }
        }

        public static void Save()
        {
            
        }

        public static void Clear()
        {
            Inputs.Clear();
            Outputs.Clear();
            Network.Clear();
        }

        public static string ToString()
        {
            var str = new StringBuilder();

            //str.Append("Inputs: ");
            //foreach (var input in Inputs) { str.Append($"{input}   "); }
            //str.Append("\n");
            foreach (var layer in Network)
            {
                str.Append("\n");
                foreach (var neuron in layer)
                {
                    str.Append(neuron.ToString());
                }   
            }
            //str.Append("\nOutputs: ");
            //foreach (var output in Outputs) { str.Append($"{output}   "); }
            //str.Append("\n");
            return str.ToString();
        }

        private static double CalculateNeuronOutput(double beta, double val)
        {
            return (double)1/(1 + Math.Exp(-beta * val));
        }
    }
}
