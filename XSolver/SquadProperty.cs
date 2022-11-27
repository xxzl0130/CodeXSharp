using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace XSolver;

/// <summary>
/// 重装小队的属性数值
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class SquadProperty
{
    /// <summary>
    /// 杀伤
    /// </summary>
    [JsonProperty("damage")]
    public int Damage;

    /// <summary>
    /// 破防
    /// </summary>
    [JsonProperty("def_break")]
    public int DefBreak;

    /// <summary>
    /// 精度
    /// </summary>
    [JsonProperty("hit")]
    public int Hit;

    /// <summary>
    /// 装填
    /// </summary>
    [JsonProperty("reload")]
    public int Reload;
}

/// <summary>
/// 重装小队的属性格数，多了一个自由格数设置
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class SquadPropertyBlock : SquadProperty
{
    /// <summary>
    /// 自由格数or偏差格数
    /// </summary>
    [JsonProperty("free")]
    public int Free;
}