using System.IO;

namespace ScoreCalculator_OCP
{
    public class DataProvider0 : IDataProvider
    {
        //We read this field from outside
        private bool _shouldParseByComma=false;

        public string[] ReadLinesFromInputFile()
        {
            string inputFilePath = "SampleInput/students.txt";

            //Read all lines
            string[] linesOfStudenst = File.ReadAllLines(inputFilePath);
            return linesOfStudenst;
        }
        
        public  string[] Split(string line)
        {
            string[] sectionOfLine = null;
            
            //TODO: Add validations
            if (_shouldParseByComma)
            {
                sectionOfLine = line.Split(',');
            }
            else
            {
                sectionOfLine = line.Split('_');
            }

            return sectionOfLine;
        }
    }
}