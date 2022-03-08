using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PhpRunner.utility
{
    public static class util
    {
        public static List<ScriptInfo> ENV = new List<ScriptInfo>(3);
        private static string PATH_CONFIG = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        private static string jsonEnv = string.Empty;

        public static void Load_ENV()
        {
            if (!File.Exists(PATH_CONFIG))
            {
                for(int i = 0; i < 3; i++)
                {
                    ScriptInfo sInfo = new ScriptInfo();
                    ENV.Add(sInfo);
                }
                Save_ENV();

            }
            jsonEnv = File.ReadAllText(PATH_CONFIG);
            ENV = JsonConvert.DeserializeObject<List<ScriptInfo>>(jsonEnv);
        }

        public static void Save_ENV()
        {
            jsonEnv = JsonConvert.SerializeObject(ENV, Formatting.Indented);
            File.WriteAllText(PATH_CONFIG, jsonEnv);
        }
    }
}
