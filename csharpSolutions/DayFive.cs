namespace csharpSolutions;

record Box(char contents, int stack);
record Movement(int amount, int source, int dest);

public class DayFive : ISolver
{
    private List<List<Box>> _boxes = new();
    private List<Movement> _movements = new();
    

    public void Initialize(List<string> input)
    {
        bool afterEmptyLine = false;
        List<string> capturedBoxes = new();
        string indexLine = "";
        
        foreach (var line in input)
        {
            if (string.IsNullOrEmpty(line))
            {
                afterEmptyLine = true;
                indexLine = capturedBoxes.Last();
                capturedBoxes.Remove(capturedBoxes.Last());
                foreach(var i in indexLine)
                {
                    if (i != ' ')
                    {
                        _boxes.Add(new List<Box>());
                        var index = indexLine.IndexOf(i);
                        foreach (var boxes in capturedBoxes)
                        {
                            var value = boxes[index];
                            if (value != ' ')
                            {
                                 var box = new Box(value, int.Parse(i.ToString()));
                                _boxes[int.Parse(i.ToString()) - 1].Add(box);                               
                            }
                        }
                    }
                }
                continue;
            }
            
            if (afterEmptyLine)
            {
                var split = line.Split(" ");
                _movements.Add(new Movement(int.Parse(split[1]), int.Parse(split[3]), int.Parse(split[5])));
            }
            else
            {
                capturedBoxes.Add(line);
            }
        }
    }

    public string PartOne()
    {
        foreach (var movement in _movements)
        {
            Move(movement);
        }

        return _boxes.Select(boxStack => boxStack[0]).Aggregate("", (a, b) => a + b.contents);
    }

    public string PartTwo()
    {
        return "";
    }

    private void Move(Movement movement)
    {
        var movedBoxes = _boxes[movement.source - 1].Take(movement.amount);
        _boxes[movement.source - 1].RemoveRange(0, movement.amount);
        _boxes[movement.dest - 1].InsertRange(0, movedBoxes);
    }
}