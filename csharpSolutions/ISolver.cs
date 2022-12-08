namespace csharpSolutions;

public interface ISolver
{
    void Initialize(List<string> input);
    long PartOne();
    long PartTwo();
}