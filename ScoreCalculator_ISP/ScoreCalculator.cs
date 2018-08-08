using System.Collections.Generic;

namespace ScoreCalculator_ISP
{
    
    //Method refactoring -> single responsibility for methods
    public class ScoreCalculator
    {  
        public void Calculate()
        {
            
            var mapper = new Mapper();
            var reader = new ReadTextFile();
            var splitter = new SplittByComma();
            
            var linesOfStudenst = reader.ReadLinesFromInputFile();

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
            {
                var sectionLine = splitter.Split(line);
         
                var s = mapper.Map(sectionLine);
                students.Add(s);
            }
            
            var exporter = new Exporter();
            exporter.ExportReport(students);
        }
    }
}