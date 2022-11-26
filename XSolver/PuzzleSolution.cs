using Newtonsoft.Json;

namespace XSolver;

/// <summary>
/// 芯片在拼图中的配置
/// </summary>
public struct ChipInPuzzle
{
    /// <summary>
    /// 芯片形状id
    /// </summary>
    [JsonProperty("ID")]
    public int GridId;

    /// <summary>
    /// 旋转方向
    /// </summary>
    [JsonProperty("rotate")]
    public int Rotate;

    public Point Position;

    [JsonProperty("x")]
    private int __x
    {
        get => Position.X;
        set => Position.X = value;
    }

    [JsonProperty("y")]
    private int __y
    {
        get => Position.Y;
        set => Position.Y = value;
    }
}

/// <summary>
/// 一组解决方案
/// </summary>
public class PuzzleSolution
{
    /// <summary>
    /// 使用的芯片配置
    /// </summary>
    public List<ChipInPuzzle> Chips = new ();
    /// <summary>
    /// 空白格数
    /// </summary>
    public int BlankBlocks = 0;
}