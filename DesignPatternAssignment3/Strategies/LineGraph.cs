using System;
using System.Collections.Generic;


namespace DesignPatternAssignment3
{
    class LineGraph : Graph
    {
        public override void DrawGraph(ICollection<ICoOrdinate> CoOrdinates)
        {
            Console.WriteLine("Drawing Line graph");
        }
    }
}
