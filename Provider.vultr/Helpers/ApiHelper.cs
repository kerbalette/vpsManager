using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace vpsManager.Helpers
{
    public static class ApiHelper
    {
        // Make this static as HttpClient object will be shared with the entire application
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            //WebProxy webProxy = new WebProxy { Address = new Uri("http://127.0.0.1:8080") };
            //HttpClientHandler httpClientHandler = new HttpClientHandler{Proxy = webProxy};
            //httpClientHandler.UseProxy = true;
      
            //httpClientHandler.AllowAutoRedirect = true;
            //httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            
            
            //ApiClient = new HttpClient(httpClientHandler);
            
            string vultrAPIKey = ConfigurationManager.AppSettings["vultrAPIKey"];
            
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", vultrAPIKey);
        }
    }
}