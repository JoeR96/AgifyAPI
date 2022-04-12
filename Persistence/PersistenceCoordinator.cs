using AgifyAPI.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace AgifyAPI.Persistence
{
    internal class PersistenceCoordinator
    {
        private static string callCountLocation = @"\Persistence.json";
        public static void SaveCountToTextFile()
        {
            File.WriteAllText(callCountLocation, JsonConvert.SerializeObject(CallCountCoordinator.CallsRemaining));
        }

        public static string ReadCountFromTextFile()
        {
            if(File.Exists(callCountLocation))
            {
                using (StreamReader file = File.OpenText(callCountLocation))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    return o2.First.ToString();
                }           
            }
            
            return string.Empty;
        }
    }
}
