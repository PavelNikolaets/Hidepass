﻿
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Hidepass.Logic.FileOperations
{
    internal class JsonService
    {
        private static readonly JsonSerializerOptions options = new()
        {
            IncludeFields = true,
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static string ToJson<T>(T inputObj) => JsonSerializer.Serialize(inputObj, options);

        public static T ToObject<T>(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(json);
            }
            catch
            {
                return default;
            }
            
        }
    }
}
