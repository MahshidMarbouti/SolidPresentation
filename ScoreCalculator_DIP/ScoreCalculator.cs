using System.Collections.Generic;

namespace ScoreCalculator_DIP
{
    
    //Method refactoring -> single responsibility for methods
    public class ScoreCalculator
    {
        private readonly IDataProvider _dataProvider;
        private readonly IMapper _mapper;
        private readonly IExporter _exporter;

        public ScoreCalculator(IDataProvider dataProvider, IMapper mapper, IExporter exporter)
        {
            _dataProvider = dataProvider;
            _mapper = mapper;
            _exporter = exporter;
        }
        public void Calculate()
        {
 
            var linesOfStudenst = _dataProvider.ReadLinesFromInputFile();

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
            {
                var sectionLine = _dataProvider.Split(line);
         
                var s = _mapper.Map(sectionLine);
                students.Add(s);
            }
            
            _exporter.ExportReport(students);
        }
    }
}