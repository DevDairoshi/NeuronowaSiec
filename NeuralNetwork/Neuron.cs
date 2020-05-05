using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Neuron
    {
        public List<double> Weights;
        public double Beta { get; set; }
        public double Value { get; set; }
        public double Output { get; set; }
        public Neuron(params double[] weights)
        {
            Beta = 1;
            Weights = new List<double>(weights);
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            str.Append($"Beta: {Beta};\t Weights: ");
            foreach (var weight in Weights)
            {
                str.Append($"{weight}   ");
            }
            str.Append("\n");
            return str.ToString();
        }
    }
}
