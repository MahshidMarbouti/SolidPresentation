using System;
using System.Collections.Generic;
using System.Linq;

namespace ScoreCalculator_LSP
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Scores { get; set; }

        public virtual double GetFinalScore()
        {
            return Scores.Average();
        }
    }

    public class VisitorStudent : Student
    {
        public override double GetFinalScore()
        {
            //Simplest Solution: return 100 as a pass score (could be a business rule)
            //we are limiting the superClass
            throw new NotImplementedException();
        }
    }
}