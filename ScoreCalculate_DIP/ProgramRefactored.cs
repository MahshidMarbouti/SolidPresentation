using System;
using ScoreCalculate_DIP;

namespace ScoreCalculate_DIP
{
    
    class ProgramRefactored
    {
        static void MainRefactored(string[] args)
        {
            Console.WriteLine("Reading students numbers:");
            var reader = (IReader)ServiceLocator.Resolve(typeof(IReader));
            var splitter = (ISplitter)ServiceLocator.Resolve(typeof(ISplitter));
            var mapper = (IMapper)ServiceLocator.Resolve(typeof(IMapper));
            var exporter = (IExporter)ServiceLocator.Resolve(typeof(IExporter));
            
            ScoreCalculator sc = new ScoreCalculator(reader, mapper, exporter, splitter);
            sc.Calculate();

            Console.WriteLine("Finished ...");
            Console.ReadKey();
        }
    }
}