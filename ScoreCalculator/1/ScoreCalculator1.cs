using System.Collections.Generic;

namespace ScoreCalculator._1
{
    
    //Method refactoring -> single responsibility for methods
    public class ScoreCalculator1
    {
        public void Calculate()
        {
            var dataProvider = new DataProvider();
            var mapper = new Mapper();
            
            var linesOfStudenst = dataProvider.ReadLinesFromInputFile();

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
            {
                var sectionLine = dataProvider.Split(line);
               
                var s = mapper.Map(sectionLine);
                students.Add(s);
            }
            
            var exporter = new Exporter();
            exporter.ExportReport(students);
        }
    }
}