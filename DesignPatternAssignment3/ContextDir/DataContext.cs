using System.Collections.Generic;

namespace DesignPatternAssignment3
{
    class DataContext : IContext
    {
        private IGraph _strategy;
        public ICollection<ICoOrdinate> CoOrdinates { get; set; }
        public DataContext(IGraph strategy)
        {
            CoOrdinates = new List<ICoOrdinate>();
            SetStrategy(strategy);
        }
        public void AddCoOrdinates(ICoOrdinate value)
        {
            CoOrdinates.Add(value);
        }
        public void GraphDrawingAlgorithmInterface()
        {
            _strategy.DrawGraph(CoOrdinates);
        }
        public void SetStrategy(IGraph graph)
        {
            this._strategy = graph;
        }
    }
}
