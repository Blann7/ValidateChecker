using Newtonsoft.Json;

namespace ValidateChecker.Configuration
{
    public class ConfigFileModel
    {
        public int Interval { get; set; }
        public string ConnectionString { get; set; } = string.Empty;
    }
}
