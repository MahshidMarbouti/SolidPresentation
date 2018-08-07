using System.IO;

namespace ScoreCalculator_ISP
{
    public class DataProviderByComma : IDataProvider
    {
        public string[] ReadLinesFromInputFile()
        {
            string inputFilePath = "SampleInput/students.txt";

            //Read all lines
            string[] linesOfStudenst = File.ReadAllLines(inputFilePath);
            return linesOfStudenst;
        }
        
        public string[] Split(string line)
        {
            string[] sectionOfLine = null;
            sectionOfLine = line.Split(',');
            return sectionOfLine;

        }
    }
    
    
    public class DataProviderByUnderscore : IDataProvider
    {
        public string[] ReadLinesFromInputFile()
        {
            string inputFilePath = "SampleInput/students.txt";

            //Read all lines
            string[] linesOfStudenst = File.ReadAllLines(inputFilePath);
            return linesOfStudenst;
        }
        
        public string[] Split(string line)
        {
            string[] sectionOfLine = null;
            sectionOfLine = line.Split('_');
            return sectionOfLine;
        }
    }
}