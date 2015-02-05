using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RedmineTimeManager.models
{
    /// <summary>
    /// API Request Class
    /// </summary>
    class Request
    {
        private String url { get; set; }
        private String key { get; set; }

        public Request()
        {
            // setup access info
            url = Properties.Settings.Default.URL;
            key = Properties.Settings.Default.Key; 
        }

        /// <summary>
        /// call api
        /// </summary>
        /// <param name="method"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public HttpResponseMessage call(String method, String parameters = "")
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Redmine-API-Key", key);
            
            String requestUrl = url + method + parameters;

            HttpResponseMessage response = client.GetAsync(requestUrl).Result;

            return response;
        }
    }
}
