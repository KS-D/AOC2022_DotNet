namespace AOCSolutionRunner;

public class InputParser
{
    public List<string> GetAllLine(string fileName)
    {
        return File.ReadLines(fileName).ToList();
    }
}