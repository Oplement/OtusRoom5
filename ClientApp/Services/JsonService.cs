namespace ClientApp.Services
{
    public class JsonService 
    {
        public string PrepareSuccessJson(string message)
        {
            var f = @"{""success"":true,""result"":" + message + "}";
            string result = @"{""success"":true,""result"":" + message + "}";
            return result;
        }

        public string PrepareErrorJson(string message)
        {
            string result = @"{""success"":false,""result"":""" + message + @"""}";
            return result;
        }
    }
}
