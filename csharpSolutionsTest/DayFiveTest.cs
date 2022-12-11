using csharpSolutions;

namespace csharpSolutionsTest;

public class DayFiveTest
{
    private List<string> _input = new()
    {
        "   [D]      ",
        "[N][C]      ",
        "[Z][M][P]   ",
        " 1  2  3",
        "",
        "move 1 from 2 to 1",
        "move 3 from 1 to 3",
        "move 2 from 2 to 1",
        "move 1 from 1 to 2",
    };

    [Fact]
    public void Initialize()
    {
        var dayFive = new DayFive();
        dayFive.Initialize(_input);
    }

    [Fact]
    public void TestDayOne()
    {
        var dayFive = new DayFive();
        dayFive.Initialize(_input);       
        Assert.Equal("", dayFive.PartOne());
    }
    
    [Fact]
    public void TestDayTwo()
    {
        
    }
}