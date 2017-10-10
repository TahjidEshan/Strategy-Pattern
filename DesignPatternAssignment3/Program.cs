using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<ICoOrdinate> CoOrdinates = new List<ICoOrdinate>();
            IGraph Graph = new BarGraph();
            //graph.SetData(CoOrdinates);
            IContext Context = new DataContext(Graph);
            Context.GraphDrawingAlgorithmInterface();
            IGraph Graph1 = new LineGraph();
            Context.SetStrategy(Graph1);
            Context.GraphDrawingAlgorithmInterface();
            Console.ReadLine();
        }
    }
}
