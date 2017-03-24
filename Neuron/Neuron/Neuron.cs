using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    public class Neuron : iNeuron
    {
        public List<double> _weights { get; set; }
        public Neuron() { }
        public Neuron(List<double> _weights)
        {
            this._weights = _weights;
        }

        public double FunctionU(List<double> arg)
        {
             var temp = 0.0;

             foreach (var item in arg.Select((value, index) => new { value, index }))
             {
               temp += _weights[item.index] * item.value;
             }

             return temp;
        }

        public double Signum(double U) => U < 0 ? -1 : 1;
    }
}
