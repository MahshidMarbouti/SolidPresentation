using System;
using System.Net.Mime;

namespace ScoreCalculate_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading students numbers:");
            IMapper mapper = new Mapper();
            ISplitter split = new SplittByComma();
            IExporter export = new Exporter();
            IReader reader = new ReadTextFile();
            
            ScoreCalculator sc = new ScoreCalculator(reader, mapper, export, split);
            sc.Calculate();
            
            Console.WriteLine("Finished ...");
            Console.ReadKey();
        }
    }
}