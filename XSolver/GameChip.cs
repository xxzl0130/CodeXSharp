using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace XSolver;

/// <summary>
/// 基础芯片设置
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class GameChip
{
    /// <summary>
    /// 形状编号
    /// </summary>
    [JsonProperty("ID")]
    public int GridId;

    /// <summary>
    /// 芯片类别
    /// </summary>
    [JsonProperty("class")]
    public ChipClass ChipClass;

    /// <summary>
    /// 宽度
    /// </summary>
    [JsonProperty("width")]
    public int Width;

    /// <summary>
    /// 高度
    /// </summary>
    [JsonProperty("height")]
    public int Height;

    /// <summary>
    /// 总格数
    /// </summary>
    [JsonProperty("blocks")]
    public int BlockCount;

    /// <summary>
    /// 旋转方向数
    /// </summary>
    [JsonProperty("direction")]
    public int Directions;

    /// <summary>
    /// 名称
    /// </summary>
    [JsonProperty("name")]
    public string Name = string.Empty;

    /// <summary>
    /// 芯片形状图
    /// </summary>
    [JsonProperty("map")]
    public string[] Shape = Array.Empty<string>();
    
    public static GameChip?[] Chips
    {
        get
        {
            if (chips == null)
                IniGameChips();
            return chips!;
        }
    }

    private static GameChip?[]? chips = null;

    private static void IniGameChips()
    {
        var chipStr = Encoding.UTF8.GetString(Resource.chips);
        var chipData = JsonConvert.DeserializeObject<List<GameChip>>(chipStr);
        Debug.Assert(chipData != null);
        var maxIndex = chipData.Max(it => it.GridId);
        chips = new GameChip[maxIndex + 1];
        foreach (var chip in chipData)
        {
            chips[chip.GridId] = chip;
        }
    }
}