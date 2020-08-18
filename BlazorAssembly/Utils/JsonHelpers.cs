using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssembly.Utils
{
    public static class JsonHelpers
    {
        public static string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value, Formatting.None);
        }
        public static T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
