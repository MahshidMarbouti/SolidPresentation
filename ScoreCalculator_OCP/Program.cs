using System;

namespace ScoreCalculator_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool _shouldParseByComma = true;
            
            IDataProvider dataProvider; 
            if (_shouldParseByComma)
            {
                dataProvider = new DataProviderByComma();

            }
            else
            {
                dataProvider = new DataProviderByUnderscore();
            }
        }
    }
}