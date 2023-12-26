namespace ClientApp
{
    public class MicroserviceDictionary
    {
        private static Dictionary<string, string> Instances = new Dictionary<string, string>()
        {
            {"Shop","http://localhost:14675" },
            {"Notification","http://localhost:43368" },
            {"Authorization","http://localhost:5107" },
        };

        public static string GetMicroserviceAdress(string name)
        {
            string result = "";

            Instances.TryGetValue(name, out result);
          
            return result;
        }
    }
}
