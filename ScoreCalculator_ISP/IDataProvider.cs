namespace ScoreCalculator_ISP
{
    public interface IDataProvider
    {
        string[] ReadLinesFromInputFile();
        string[] Split(string line);
    }
}