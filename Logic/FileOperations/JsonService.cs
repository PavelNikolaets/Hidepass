﻿
using System.Text.Json;

namespace Hidepass.Logic.FileOperations
{
    internal class JsonService
    {
        private static readonly JsonSerializerOptions options = new()
        {
            IncludeFields = true,
            WriteIndented = true,
        };

        public static string ToJson<T>(T inputObj)
        {
            return JsonSerializer.Serialize(inputObj, options);
        }

        public static T ToObject<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
