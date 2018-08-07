namespace ScoreCalculator_DIP
{
    public interface IDataProvider
    {
        string[] ReadLinesFromInputFile();
        string[] Split(string line);
    }
}