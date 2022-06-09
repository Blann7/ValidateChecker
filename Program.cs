namespace ValidateChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int interval = Configuration.Init.GetInterval();

            while (true)
            {
                Console.WriteLine("Старт итерации проверки");

                RoleValidityChecker rvc = new RoleValidityChecker();
                rvc.StartCheckAsync();

                Thread.Sleep(interval); // change
            }
        }
    }
}
