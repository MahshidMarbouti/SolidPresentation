using System.Collections.Generic;
using System.Linq;

namespace ScoreCalculate_DIP
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