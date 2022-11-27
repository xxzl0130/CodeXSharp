using System.Text;
using System.Text.RegularExpressions;

namespace XSolver;

public static class Utils
{
    public static string GetResourceFileString(string name, Encoding? encoding = null)
    {
        name = name.Replace('-', '_');
        if (Regex.Match(name, @"^[\d]").Success)
        {
            name = "_" + name;
        }
        var bytes = Resource.ResourceManager.GetObject(name) as byte[];
        if (bytes == null)
            return string.Empty;
        encoding ??= Encoding.UTF8;
        return encoding.GetString(bytes);
    }
}
