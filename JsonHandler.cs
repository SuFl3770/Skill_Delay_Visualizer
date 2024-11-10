using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using System.Security.Cryptography;

namespace Skill_Delay_Visualizer
{
    internal class JsonHandler
    {
        private static JsonHandler? SingleClass;
        private string path = @".\config.json";
        private string soundPath = @".\sound.wav";

        JObject newConfigFile = new JObject(
            new JProperty("key", 65),
            new JProperty("time", 200),
            new JProperty("ver", 1)
        );

        public int key, time;
        
        public static JsonHandler Instance()
        {
            if (SingleClass == null)
            {
                SingleClass = new JsonHandler();
            }
            return SingleClass;
        }

        public void ConfigFileCheck()
        {
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.WriteAllText(path, newConfigFile.ToString());
            }
            if (!System.IO.File.Exists(soundPath))
            {
                soundPath = "none";
            }
        }

        public string ReturnSoundPath()
        {
            return soundPath;
        }

        public void LoadData()
        {
            ConfigFileCheck();
            StreamReader file = System.IO.File.OpenText(path);
            JsonTextReader reader = new JsonTextReader(file);
            JObject json = (JObject)JToken.ReadFrom(reader);

            key = (int)json["key"];
            time = (int)json["time"];
            file.Close();
        }

        public void SaveData()
        {
            newConfigFile["key"] = key;
            newConfigFile["time"] = time;
            System.IO.File.WriteAllText(path, newConfigFile.ToString());
        }
    }
}
