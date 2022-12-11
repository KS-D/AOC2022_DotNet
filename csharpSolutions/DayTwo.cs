namespace csharpSolutions;

public class DayTwo : ISolver
{
    private Dictionary<string, (int partOneVal, int partTwoVal)> _gameValues = new();
    private long _partOneScore = 0;
    private long _partTwoScore = 0;
    
    public void Initialize(List<string> input)
    {
        var rockVal = 1;
        var paperVal = 2;
        var scissorVal = 3;
        var drawVal = 3;
        var winVal = 6;
        
        _gameValues.Add("A X", (rockVal + drawVal, scissorVal));
        _gameValues.Add("A Y", (paperVal + winVal, rockVal + drawVal));
        _gameValues.Add("A Z", (scissorVal, paperVal + winVal));
        _gameValues.Add("B X", (rockVal, rockVal));
        _gameValues.Add("B Y", (paperVal + drawVal, paperVal + drawVal));
        _gameValues.Add("B Z", (scissorVal + winVal, scissorVal + winVal));
        _gameValues.Add("C X", (rockVal + winVal, paperVal));
        _gameValues.Add("C Y", (paperVal, scissorVal + drawVal));
        _gameValues.Add("C Z", (scissorVal + drawVal, rockVal + winVal));

        var gameScores = 
            input
            .Select(line => _gameValues[line])
            .Aggregate((a, b) => (a.partOneVal + b.partOneVal, a.partTwoVal + b.partTwoVal));
        _partOneScore = gameScores.partOneVal;
        _partTwoScore = gameScores.partTwoVal;
    }
    
    public string PartOne() => _partOneScore.ToString();
    public string PartTwo() => _partTwoScore.ToString();
}