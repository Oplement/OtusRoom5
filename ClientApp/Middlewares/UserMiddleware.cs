using ClientApp.Services;

namespace ClientApp.Middlewares
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;

        RequestService _requestService;
        public UserMiddleware(RequestDelegate next, RequestService requestService)
        {
            _next = next;
            _requestService = requestService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // забирмаем из сервиса авторизации пользователя
            var response = _requestService.SendGet
                (MicroserviceDictionary.GetMicroserviceAdress("Authorization"), "auth/getUserInfo", context);

           
            // если пользователь забрался по токену успешно то все норм
            if (response.success )
            {
                var user = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.result.ToString());
                context.Items.Add("userid", user.id); 
                context.Items.Add("email", user.email);
                context.Items.Add("username", user.username);
                context.Items.Add("role", user.role);
                context.Items.Add("userphoto", user.userphoto);

                
                var responseBalance = _requestService.SendGet
              (MicroserviceDictionary.GetMicroserviceAdress("Shop"), $"api/balances/{user.id}", context);
                if (responseBalance.success)
                {
                    var balance = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseBalance.result.ToString());
                    context.Items.Add("balance", balance.amount);
                    context.Items.Add("forSend", balance.amountForSend);
                }
               
            }// если не забрался, то кидаем на авторизацию
            else if(!context.Request.Path.Value.Contains("auth"))
            {
                context.Response.Redirect("/auth");
            }

             await _next(context);
        }
    }
}
