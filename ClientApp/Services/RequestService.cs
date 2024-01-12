using ClientApp.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json;

namespace ClientApp.Services
{
    public class RequestService
    {
        public JsonService _jsonService;
        public RequestService(JsonService jsonService)
        {
                _jsonService = jsonService;
        }
        public ResponseModel SendPost(string microservice, string api_path, object body) => SendPost(microservice,api_path,body, null);
        
        public ResponseModel SendPost(string microservice, string api_path, object body, HttpContext context)
        {
            try
            {
                string url = "";

                url = microservice + "/" + api_path;

                var request = WebRequest.Create(url);
                request.Method = "POST";

                string json = "";
                byte[] byteArray;
             
                json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
                byteArray = Encoding.UTF8.GetBytes(json);
                request.ContentLength = byteArray.Length;

                request.ContentType = "application/json";

                request.Credentials = CredentialCache.DefaultNetworkCredentials;

                if (context != null)
                {
                    if (context.Request.Cookies.ContainsKey(".AspNetCore.User.Id"))
                    {
                        request.Headers.Add(".AspNetCore.User.Id", context.Request.Cookies[".AspNetCore.User.Id"]);
                        request.Headers.Add("Authorization", "Bearer " + context.Request.Cookies[".AspNetCore.User.Id"]);

                    }
                }

                using var reqStream = request.GetRequestStream();
                reqStream.Write(byteArray, 0, byteArray.Length);
           
                using var response = request.GetResponseAsync().Result;

                using var respStream = response.GetResponseStream();

                using var reader = new StreamReader(respStream);
                string data = reader.ReadToEnd();
                
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(_jsonService.PrepareSuccessJson(data));
            }
            catch (Exception ex)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(_jsonService.PrepareErrorJson(ex.Message));
            }
        }

        public ResponseModel SendGet(string microservice, string api_path,  HttpContext context)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    if (context != null)
                    {
                        if (context.Request.Cookies.ContainsKey(".AspNetCore.User.Id"))
                        {
                            client.DefaultRequestHeaders.Add(".AspNetCore.User.Id", context.Request.Cookies[".AspNetCore.User.Id"]);
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + context.Request.Cookies[".AspNetCore.User.Id"]);
                        }

                        if (context.Request.Headers.ContainsKey(".AspNetCore.User.Id"))
                        {
                            client.DefaultRequestHeaders.Add(".AspNetCore.User.Id", context.Request.Headers[".AspNetCore.User.Id"][0]);
                            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + context.Request.Headers[".AspNetCore.User.Id"][0]);
                        }
                    }

                 
                    var responseString = client.GetStringAsync(microservice + "/" + api_path).Result;

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(_jsonService.PrepareSuccessJson(responseString));
                }

            }
            catch (Exception ex)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(_jsonService.PrepareErrorJson(ex.Message));
            }
        }
    }
}
