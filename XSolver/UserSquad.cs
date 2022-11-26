using Newtonsoft.Json;

namespace XSolver;

[JsonObject(MemberSerialization.OptIn)]
public class UserSquad
{
    /// <summary>
    /// 编号
    /// </summary>
    [JsonProperty("id")]
    public int Id;

    /// <summary>
    /// 小队类型编号
    /// </summary>
    [JsonProperty("squad_id")]
    public int SquadId;

    /// <summary>
    /// 等级
    /// </summary>
    [JsonProperty("squad_level")]
    public int Level;

    /// <summary>
    /// 伤害数值
    /// </summary>
    [JsonProperty("assist_damage")]
    public int DamageValue;

    /// <summary>
    /// 装填数值
    /// </summary>
    [JsonProperty("assist_reload")]
    public int ReloadValue;

    /// <summary>
    /// 命中数值
    /// </summary>
    [JsonProperty("assist_hit")]
    public int HitValue;

    /// <summary>
    /// 破防数值
    /// </summary>
    [JsonProperty("assist_def_break")]
    public int DefBreakValue;
}
