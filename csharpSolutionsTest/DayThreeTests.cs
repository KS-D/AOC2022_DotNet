using csharpSolutions;

namespace csharpSolutionsTest;

public class DayThreeTests
{
    private List<string> input = new()
    {
        "vJrwpWtwJgWrhcsFMMfFFhFp",
        "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
        "PmmdzqPrVvPwwTWBwg",
        "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
        "ttgJtRGJQctTZtZT",
        "CrZsJsPPZsGzwwsLwLmpwMDw"
    };

    [Fact]
    public void TestPartOne()
    {
        DayThree day3 = new();
        day3.Initialize(input);
        var result = day3.PartOne();
        Assert.Equal(157, result);
    }

    [Fact]
    public void TestPartTwo()
    {
        DayThree day3 = new();
        day3.Initialize(input);
        var result = day3.PartTwo();
        Assert.Equal(70, result);
    }
    
    [Fact]
    public void CharToIntTest()
    {
        DayThree day3 = new();
        Assert.Equal(16, day3.CharToInt('p'));
        Assert.Equal(38, day3.CharToInt('L'));
        Assert.Equal(42, day3.CharToInt('P'));
        Assert.Equal(22, day3.CharToInt('v'));
        Assert.Equal(20, day3.CharToInt('t'));
        Assert.Equal(19, day3.CharToInt('s'));
    }
}