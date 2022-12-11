using csharpSolutions;

namespace csharpSolutionsTest;

public class DayFourTests
{
    private List<string> input = new List<string>
    {
        "2-4,6-8",
        "2-3,4-5",
        "5-7,7-9",
        "2-8,3-7",
        "6-6,4-6",
        "2-6,4-8"
    };

    [Fact]
    public void PartOneTest()
    {
        var day4 = new DayFour();
        day4.Initialize(input);
        Assert.Equal("2", day4.PartOne());
    }
    
    [Fact]
    public void PartTwoTest()
    {
        var day4 = new DayFour();
        day4.Initialize(input);
        Assert.Equal("4", day4.PartTwo());
    }
    
}