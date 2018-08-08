using System.IO;

namespace ScoreCalculate_DIP
{
    public interface IReader
    {
        string[] ReadLinesFromInputFile();
       
    }
    
    public class ReadTextFile : IReader
    {
        public string[] ReadLinesFromInputFile()
        {
            string inputFilePath = "SampleInput/students.txt";

            //Read all lines
            string[] linesOfStudenst = File.ReadAllLines(inputFilePath);
            return linesOfStudenst;
        }
    }
    
    

    
}