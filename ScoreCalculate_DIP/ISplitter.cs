namespace ScoreCalculate_DIP
{
    public interface ISplitter
    {
        string[] Split(string line);
    }

    public class SplittByComma : ISplitter
    {
        
        public string[] Split(string line)
        {
            string[] sectionOfLine = null;
            sectionOfLine = line.Split('_');
            return sectionOfLine;
        }

    }

    public class SplittByUnderScore : ISplitter
    {
        public string[] Split(string line)
        {
            string[] sectionOfLine = null;
            sectionOfLine = line.Split(',');
            return sectionOfLine;

        }
    }
    
}