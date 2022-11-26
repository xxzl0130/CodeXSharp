using Newtonsoft.Json;

namespace XSolver;

public struct Point
{
    public int X;
    public int Y;
}

/// <summary>
/// 芯片类别
/// </summary>
public enum ChipClass
{
    Class56 = 5061,
    Class551 = 5051,
    Class552 = 5052
}

/// <summary>
/// 芯片颜色
/// </summary>
public enum ChipColor
{
    Orange = 1,
    Blue = 2,
}
