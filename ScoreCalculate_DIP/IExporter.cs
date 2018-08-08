using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ScoreCalculate_DIP
{
    public interface IExporter
    {
        void ExportReport(List<Student> students);
    }

    public class Exporter : IExporter
    {
        public void ExportReport(List<Student> students)
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
    }
}