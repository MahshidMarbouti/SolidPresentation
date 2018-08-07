using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ScoreCalculator._0
{
    //Method refactoring -> single responsibility for methods
    public class ScoreCalculator0
    {
        public void Calculate()
        {
            var linesOfStudenst = ReadLinesFromInputFile();

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
            {
                var s = ParseLineToStudent(line);
                students.Add(s);
            }

            ExportReport(students);
        }

        private void ExportReport(List<Student> students)
        {
            StringBuilder sb = new StringBuilder();

            //Get final score and export
            foreach (var student in students)
            {
                double finalScore = student.GetFinalScore();

                sb.AppendLine($"{student.Id},{student.Name},{finalScore}");
            }

            string outputFilePath = "studentsFinalScores.txt";

            File.WriteAllText(outputFilePath, sb.ToString());
        }

        private string[] ReadLinesFromInputFile()
        {
            string inputFilePath = "SampleInput/students.txt";

            //Read all lines
            string[] linesOfStudenst = File.ReadAllLines(inputFilePath);
            return linesOfStudenst;
        }
        
        private Student ParseLineToStudent(string line)
        {
            
            //TODO: Add validations
            string[] sectionOfLine = line.Split(',');

            Student s = new Student();

            s.Id = int.Parse(sectionOfLine[0]);
            s.Name = sectionOfLine[1];

            s.Scores = new List<int>();

            for (int i = 2; i < 5; i++)
            {
                s.Scores.Add(int.Parse(sectionOfLine[i]));
            }

            return s;
        }

       
    }
}