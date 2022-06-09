namespace ValidateChecker.Configuration
{
    public class ConfigException : Exception
    {
        public ConfigException(string message) : base(message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ConfigException: " + message);
            Console.ResetColor();
        }
    }
}
