using System;
using System.Collections.Generic;


namespace DesignPatternAssignment3
{
    class BarGraph : Graph
    {
        public override void DrawGraph(ICollection<ICoOrdinate> CoOrdinates)
        {
            Console.WriteLine("Drawing Bar graph");
        }
    }
}
