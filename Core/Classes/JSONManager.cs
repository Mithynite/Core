using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Core.Classes
{
    public class JSONManager
    {
        
        public static IEnumerable<T> Read<T>(string path)
        {
            using (var fileStream = File.OpenText(path))
            using (var jsonReader = new JsonTextReader(fileStream))
            {
                var serializer = new JsonSerializer();

                while (jsonReader.Read() && jsonReader.TokenType != JsonToken.EndArray)
                {
                    var obj = serializer.Deserialize<T>(jsonReader);
                    yield return obj;
                }
            }
        }

        public void ImportToTable<T>(T ta)
        {
            //TODO
        }
    }
}
