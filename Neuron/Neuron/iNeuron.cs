using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    interface iNeuron
    {
        double FunctionU(List<double> arg);
        double Signum(double U);
    }
}
