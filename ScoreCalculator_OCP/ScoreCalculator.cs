using System.Collections.Generic;
using System.Data.SqlTypes;

namespace ScoreCalculator_OCP
{
    
    //Method refactoring -> single responsibility for methods
    public class ScoreCalculator
    {
        private IDataProvider _dataProvider;

        public ScoreCalculator(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;

        }
        public void Calculate()
        {
            
            var mapper = new Mapper();
            
            var linesOfStudenst = _dataProvider.ReadLinesFromInputFile();

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
            {
                var sectionLine = _dataProvider.Split(line);
         
                var s = mapper.Map(sectionLine);
                students.Add(s);
            }
            
            var exporter = new Exporter();
            exporter.ExportReport(students);
        }
    }
}