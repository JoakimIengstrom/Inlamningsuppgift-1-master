using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Frontend.Modules.Plot
{
    class FunctionCollection
    {
        // TODO Vad är det för två typer som '_functions' Dictionary:n kopplar samman här?
        private readonly Dictionary<string, Func<double, double>> _functions;

        public FunctionCollection()
        {
            _functions = new ()
            {
                { "sin(x)", x => Math.Sin(x) },
                { "2x + 1", x => 2*x + 1 },
                { "x mod 0.5", x => x % 0.5 },
                { "x\u00b2", x => Math.Min(x, 2) },
                { "min(x, 2)", x => Math.Pow(x, 2) }
            };
        }

        public string[] GetAvailableFunctions()
        {
            return _functions.Keys.ToArray();
        }

        public Series CreateDataForPlot(string name)
        {
            LineSeries result = new LineSeries();

            for (double x = -10; x < 10; x += 0.1)
            {
                var function = _functions[name];
                double y = function(x);

                result.Points.Add(new DataPoint(x, y));
            }

            return result;
        }
    }
}
