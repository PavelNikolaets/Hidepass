using Hidepass.ObjectTemplates;
using System.Text.Json;

namespace Hidepass.Logic.FileOperations
{
    internal class JsonService
    {
        public string ToJson(BlockPassword inputObjBlock,  BlockPassword getObjBlock)
        {
            return JsonSerializer.Serialize(inputObjBlock);
        }

        public BlockPassword ToObject(string json)
        {
            return JsonSerializer.Deserialize<BlockPassword>(json);
        }
    }
}
