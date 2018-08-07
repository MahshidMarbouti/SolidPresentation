using System.Collections.Generic;
using System.Linq;

namespace ScoreCalculator_ISP
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public double GetFinalScore()
        {
            return Scores.Average();
        }
    }
}