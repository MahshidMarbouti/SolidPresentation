using System.Collections.Generic;
using System.IO;

namespace ScoreCalculator._1
{
    public interface IDataProvider
    {
        string[] ReadLinesFromInputFile();
        string[] Split(string line);
    }

    public class DataProvider : IDataProvider
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
            //TODO: Add validations
            string[] sectionOfLine = line.Split(',');
            return sectionOfLine;

        }

    }
}