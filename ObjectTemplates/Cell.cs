
using System.Text.Json.Serialization;

namespace Hidepass.ObjectTemplates
{
    internal class RootCell
    {
        [JsonPropertyName("Cells")]
        public List<CellObject> Cells { get; set; } = [];
    }

    internal class CellObject(string Name, string Description, string Login, string Password)
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; } = Name;
        [JsonPropertyName("Description")]
        public string Description { get; set; } = Description;
        [JsonPropertyName("Login")]
        public string Login { get; set; } = Login;
        [JsonPropertyName("Password")]
        public string Password { get; set; } = Password;
    }
}
