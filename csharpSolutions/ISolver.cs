namespace csharpSolutions;

public interface ISolver
{
    void Initialize(List<string> input);
    string PartOne();
    string PartTwo();
}