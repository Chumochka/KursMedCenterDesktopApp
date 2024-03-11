using MedCenter.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MedCenter
{
    public class fetchData
    {
        string site = "https://e270-37-193-14-146.ngrok-free.app/";
        public string GetRequest(string url_string)
        {
            using(var client = new HttpClient())
            {
                var url = new Uri(site + url_string);
                var result = client.GetAsync(url).Result;
                return result.Content.ReadAsStringAsync().Result;
            }
        }
        public string PostRequest(string url_string, string json)
        {
            using(var client = new HttpClient())
            {
                var url = new Uri(site + url_string);
                var json_object = new StringContent(json, Encoding.UTF8, "application/json");
                return client.PostAsync(url, json_object).Result.Content.ReadAsStringAsync().Result;
            }
        }
        public string PutRequest(string url_string, string json)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri(site + url_string);
                var json_object = new StringContent(json, Encoding.UTF8, "application/json");
                return client.PutAsync(url, json_object).Result.Content.ReadAsStringAsync().Result;
            }
        }
        public string DeleteRequest(string url_string)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri(site + url_string);
                var result = client.DeleteAsync(url).Result;
                return result.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
