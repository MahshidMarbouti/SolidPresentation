using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Base
{
    public class ScoreCalculator
    {
        public void Calculate()
        {
            string inputFilePath = "SampleInput/students.txt";

            //Read all lines
            string[] linesOfStudenst = File.ReadAllLines(inputFilePath);

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
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

                students.Add(s);
            }

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

    }
}