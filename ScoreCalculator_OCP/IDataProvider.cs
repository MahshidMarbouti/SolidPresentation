namespace ScoreCalculator_OCP
{
    public interface IDataProvider
    {
        string[] ReadLinesFromInputFile();
        string[] Split(string line);
    }
}