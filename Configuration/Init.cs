using Newtonsoft.Json;

namespace ValidateChecker.Configuration
{
    public static class Init
    {
        private static ConfigFileModel? jsonData = 
            JsonConvert.DeserializeObject<ConfigFileModel>(File.ReadAllText(
                $"{Environment.CurrentDirectory}\\Configuration\\config.json"));
        public static int GetInterval()
        {
            if (jsonData is null)
                throw new ConfigException("jsonData is null! (ValidateChecker:Configuration/Init.cs)");
            return jsonData.Interval;
        }
        public static string GetConnectionString()
        {
            if (jsonData is null)
                throw new ConfigException("jsonData is null! (ValidateChecker:Configuration/Init.cs)");
            return jsonData.ConnectionString;
        }
    }
}
