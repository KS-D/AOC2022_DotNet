namespace csharpSolutions;

public record Elf(int lowerRange, int upperRange);
public class DayFour : ISolver
{
    
    private List<(Elf elf1, Elf elf2)> _elfCleaning = new();

    public void Initialize(List<string> input)
    {
        foreach (var lines in input)
        {
            var split = lines.Split(',');
            var firstSplit = split[0].Split('-');
            var secondSplit = split[1].Split('-');
            _elfCleaning.Add((new Elf(int.Parse(firstSplit[0]), int.Parse(firstSplit[1])),
                new Elf(int.Parse(secondSplit[0]), int.Parse(secondSplit[1]))));
        }
    }

    public string PartOne()
    {
        long result = 0;
        foreach (var elfPair in _elfCleaning)
        {
            if (elfPair.elf1.lowerRange >= elfPair.elf2.lowerRange &&
                elfPair.elf1.upperRange <= elfPair.elf2.upperRange)
                result++;
            else if (elfPair.elf2.lowerRange >= elfPair.elf1.lowerRange &&
                     elfPair.elf2.upperRange <= elfPair.elf1.upperRange)
                result++;
        }

        return result.ToString();
    }

    public string PartTwo()
    {
        long result = 0;
        foreach (var elfPair in _elfCleaning)
        {
            if (elfPair.elf1.lowerRange >= elfPair.elf2.lowerRange && elfPair.elf1.lowerRange <= elfPair.elf2.upperRange 
                || elfPair.elf1.upperRange >= elfPair.elf2.lowerRange && elfPair.elf1.upperRange <= elfPair.elf2.upperRange)
                result++;
            else if (elfPair.elf2.lowerRange >= elfPair.elf1.lowerRange && elfPair.elf2.lowerRange <= elfPair.elf1.upperRange
                      || elfPair.elf2.upperRange >= elfPair.elf1.lowerRange && elfPair.elf2.upperRange <= elfPair.elf1.upperRange)
                result++;
        }

        return result.ToString();
    }
}