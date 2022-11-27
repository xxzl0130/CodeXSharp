using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace XSolver;

[DebuggerDisplay("{Name}")]
[JsonObject(MemberSerialization.OptIn)]
public class SquadConfig
{
    /// <summary>
    /// 名称
    /// </summary>
    [JsonProperty("name")]
    public string Name = string.Empty;

    public class SolutionConfig
    {
        [JsonProperty("blank")]
        public int BlankBlocks = 0;
        [JsonProperty("file")]
        public string ConfigFile = string.Empty;
        /// <summary>
        /// 拼图方案，由ConfigFile加载
        /// </summary>
        [JsonIgnore]
        public List<PuzzleSolution> Solutions = new ();
    }
    /// <summary>
    /// 方案表
    /// </summary>
    [JsonProperty("config")]
    public Dictionary<string, SolutionConfig> SolutionConfigs = new ();

    [JsonProperty("width")]
    public int Width;

    [JsonProperty("height")]
    public int Height;

    /// <summary>
    /// 格数
    /// </summary>
    [JsonProperty("blocks")]
    public int BlockCount;

    [JsonProperty("color")]
    public ChipColor Color;

    /// <summary>
    /// 旋转对称性，不为0表示旋转n次90度后相同
    /// </summary>
    [JsonProperty("palindrome")]
    public int Palindrome;

    /// <summary>
    /// 拼图样式
    /// </summary>
    [JsonProperty("map")]
    public string[] Map = Array.Empty<string>();

    [JsonProperty("MaxValues")]
    public SquadProperty MaxValue = new ();

    [JsonProperty("MaxBlocks")]
    public SquadPropertyBlock MaxBlock = new ();

    public static SquadConfig? LoadFromResource(string resourceName)
    {
        var data = Utils.GetResourceFileString(resourceName);
        if (string.IsNullOrEmpty(data))
            return null;
        var config = JsonConvert.DeserializeObject<SquadConfig>(data);
        if (config == null)
            return config;
        foreach (var solutionConfig in config.SolutionConfigs)
        {
            data = Utils.GetResourceFileString(solutionConfig.Value.ConfigFile);
            if (string.IsNullOrEmpty(data))
                continue;
            solutionConfig.Value.Solutions = JsonConvert.DeserializeObject<List<PuzzleSolution>>(data)!;
        }

        return config;
    }
}