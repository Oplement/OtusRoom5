using ClientApp.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

namespace ClientApp.Services
{
    public class RequestService
    {
        public JsonService _jsonService;
        public RequestService(JsonService jsonService)
        {
                _jsonService = jsonService;
        }

        public ResponseModel SendGet(string url,  HttpContext context)
        {
         
            try
            {
                using (var client = new HttpClient())
                {
                    if (context != null)
                    {
                        if (context.Request.Cookies.ContainsKey(".AspNetCore.Application.Id"))
                        {
                            client.DefaultRequestHeaders.Add(".AspNetCore.Application.Id", context.Request.Cookies[".AspNetCore.Application.Id"]);
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + context.Request.Cookies[".AspNetCore.Application.Id"]);
                        }

                        if (context.Request.Headers.ContainsKey(".AspNetCore.Application.Id"))
                        {
                            client.DefaultRequestHeaders.Add(".AspNetCore.Application.Id", context.Request.Headers[".AspNetCore.Application.Id"][0]);
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + context.Request.Headers[".AspNetCore.Application.Id"][0]);
                        }
                    }

                 
                    var responseString = client.GetStringAsync(url).Result;

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(responseString);
                }

            }
            catch (Exception ex)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(_jsonService.PrepareErrorJson(ex.Message));
            }

        }
        public string SendPost()
        {
            return "";
        }
    }
}
