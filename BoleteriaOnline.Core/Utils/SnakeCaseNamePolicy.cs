using System.Text.Json;
using BoleteriaOnline.Web.Extensions;

namespace BoleteriaOnline.Web.Utils;
public class SnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        return new string(name.ToSnakeCase().ToArray());
    }
}
