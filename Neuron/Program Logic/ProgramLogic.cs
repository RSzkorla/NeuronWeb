using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron.Program_Logic
{
    public class ProgramLogic
    {
        public async Task<int> Execute(List<Neuron> _web, List<double[]> _entry, List<double[]> _marks)
        {
            return await Task.Run(() =>
            {
                #region Variables
                bool work = true;
                int count = 0;
                int check = 0;
                int k = 0;
                #endregion

                while(work)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        count++;

                        var signum = _web[i].Signum(_web[i].FunctionU(_entry.ElementAt(k).ToList()));

                        if (_marks.ElementAt(k)[i] != signum)
                        {
                            double a = ((_marks.ElementAt(k)[i] - signum * 0.5));
                            var temp1 = _entry.ElementAt(k).Select(x => x * a).ToArray();
                            for (int j = 0; j < 3; j++)
                            {
                                _web[i]._weights[j] += temp1[j];
                                check = 0;
                            }
                        }
                        else check++;
                        if (check == 4) work = false;
                    }
                }
                return count;
            });
        }
    }
}
