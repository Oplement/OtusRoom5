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
                context.Items.Add("username", user.username);
                context.Items.Add("userphoto", user.userphoto);
                context.Items.Add("balance", 10);
                context.Items.Add("forSend", 20);
            }// если не забрался, то кидаем на авторизацию
            else if(!context.Request.Path.Value.Contains("auth"))
            {
                context.Response.Redirect("/auth");
            }

             await _next(context);
        }
    }
}
