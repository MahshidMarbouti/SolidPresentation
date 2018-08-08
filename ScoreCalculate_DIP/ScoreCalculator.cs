using System.Collections.Generic;
using ScoreCalculator_DIP;

namespace ScoreCalculate_DIP
{
    
    //Method refactoring -> single responsibility for methods
    public class ScoreCalculator
    {
        private readonly IReader _reader;
        private readonly ISplitter _splitter;
        private readonly IMapper _mapper;
        private readonly IExporter _exporter;

        public ScoreCalculator(IReader reader, IMapper mapper, IExporter exporter, ISplitter splitter)
        {
            _reader = reader;
            _mapper = mapper;
            _exporter = exporter;
            _splitter = splitter;
        }
        public void Calculate()
        {
 
            var linesOfStudenst = _reader.ReadLinesFromInputFile();

            List<Student> students=new List<Student>();
                     
            //Parse student info
            foreach (string line in linesOfStudenst)
            {
                var sectionLine = _splitter.Split(line);
         
                var s = _mapper.Map(sectionLine);
                students.Add(s);
            }
            
            _exporter.ExportReport(students);
        }
    }
}