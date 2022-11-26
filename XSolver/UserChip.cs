using Newtonsoft.Json;

namespace XSolver;

/// <summary>
/// 游戏内芯片数据
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class UserChip
{
    /// <summary>
    /// 顺序编号
    /// </summary>
    public int No;

    /// <summary>
    /// 游戏内id
    /// </summary>
    [JsonProperty("id")]
    public int Id;

    /// <summary>
    /// 芯片类别
    /// </summary>
    [JsonProperty("chip_id")]
    public ChipClass ChipClass;

    /// <summary>
    /// 芯片强化经验
    /// </summary>
    [JsonProperty("chip_exp")]
    public int Exp;

    /// <summary>
    /// 芯片强化等级
    /// </summary>
    [JsonProperty("chip_level")]
    public int Level;

    /// <summary>
    /// 颜色
    /// </summary>
    [JsonProperty("color_id")]
    public ChipColor Color;

    /// <summary>
    /// 形状编号
    /// </summary>
    [JsonProperty("grid_id")]
    public int GridId;

    /// <summary>
    /// 装备在哪个重装小队上
    /// </summary>
    [JsonProperty("squad_with_user_id")]
    public int SquadId;

    /// <summary>
    /// 所在位置
    /// </summary>
    public Point Position;

    [JsonProperty("position")]
    private string __position
    {
        get => $"{Position.X},{Position.Y}";
        set
        {
            var data = value.Split(',');
            if (data.Length < 2)
                return;
            int.TryParse(data[0], out Position.X);
            int.TryParse(data[1], out Position.Y);
        }
    }

    /// <summary>
    /// 旋转方向，0-3
    /// </summary>
    public int Rotate;

    [JsonProperty("shape_info")]
    private string __rotate
    {
        get => $"{Rotate},0";
        set
        {
            var data = value.Split(',');
            if (data.Length < 2)
                return;
            int.TryParse(data[0], out Rotate);
        }
    }

    /// <summary>
    /// 伤害格数
    /// </summary>
    [JsonProperty("assist_damage")]
    public int DamageBlock;

    /// <summary>
    /// 装填格数
    /// </summary>
    [JsonProperty("assist_reload")]
    public int ReloadBlock;

    /// <summary>
    /// 命中格数
    /// </summary>
    [JsonProperty("assist_hit")]
    public int HitBlock;

    /// <summary>
    /// 破防格数
    /// </summary>
    [JsonProperty("assist_def_break")]
    public int DefBreakBlock;

    /// <summary>
    /// 是否锁定
    /// </summary>
    public bool Locked;
    
    [JsonProperty("is_locked")]
    private string __locked
    {
        get => Locked ? "1" : "0";
        set => Locked = value == "1";
    }
}