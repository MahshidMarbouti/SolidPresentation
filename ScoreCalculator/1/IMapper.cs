﻿using System.Collections.Generic;

namespace ScoreCalculator._1
{
    public interface IMapper
    {
        Student Map(string[] sectionOfLine);
    }

    class Mapper : IMapper
    {
        public Student Map(string[] sectionOfLine)
        {
            var s = new Student();

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