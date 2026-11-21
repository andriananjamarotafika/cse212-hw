/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>

    Dictionary<ValueTuple<int, int>, bool[]> blocus = new()
    {
        { (1, 3), new[] { false, false, false, false } },
        { (2, 5), new[] { false, false, false, false } },
        { (2, 6), new[] { false, false, false, false } },
        { (3, 1), new[] { false, false, false, false } },
        { (3, 2), new[] { false, false, false, false } },
        { (3, 3), new[] { false, false, false, false } },
        { (4, 2), new[] { false, false, false, false } },
        { (4, 5), new[] { false, false, false, false } },
        { (4, 6), new[] { false, false, false, false } },
        { (6, 2), new[] { false, false, false, false } },
        { (6, 4), new[] { false, false, false, false } },
        { (6, 5), new[] { false, false, false, false } }

    };
    public void MoveLeft()
    {
        int check_X = _currX - 1;
        if (_currX == 1 && _currY == 1)
            _mazeMap[(_currX, _currY)] = [false, true, false, true]; //L,R,U,D

        if (_mazeMap[(_currX, _currY)][0] == false || blocus.ContainsKey((check_X, _currY)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currX--;
            if (_currX == 1)
                _mazeMap[(_currX, _currY)][0] = false;
            else
                _mazeMap[(_currX, _currY)][0] = true;

        }

    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        int check_X = _currX + 1;
        if (_currX == 1 && _currY == 1)
            _mazeMap[(_currX, _currY)] = [false, true, false, true]; //L,R,U,D

        if (_mazeMap[(_currX, _currY)][1] == false || blocus.ContainsKey((check_X, _currY)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currX++;
            if (_currX == 6)
            {
                _mazeMap[(_currX, _currY)][1] = false;
            }
            else
            {
                _mazeMap[(_currX, _currY)][1] = true;
            }

        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        int check_Y = _currY - 1;
        if (_currX == 1 && _currY == 1)
            _mazeMap[(_currX, _currY)] = [false, true, false, true]; //L,R,U,D

        if (_mazeMap[(_currX, _currY)][2] == false || blocus.ContainsKey((_currX, check_Y)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currY--;
            if (_currY == 1)
                _mazeMap[(_currX, _currY)][2] = false;
            else
                _mazeMap[(_currX, _currY)][2] = true;

        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        int check_Y = _currY + 1;
        if (_currX == 1 && _currY == 1)
            _mazeMap[(_currX, _currY)] = [false, true, false, true]; //L,R,U,D

        if (_mazeMap[(_currX, _currY)][3] == false || blocus.ContainsKey((_currX, check_Y)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currY++;
            if (_currY == 6)
                _mazeMap[(_currX, _currY)][3] = false;
            else
                _mazeMap[(_currX, _currY)][3] = true;

        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}