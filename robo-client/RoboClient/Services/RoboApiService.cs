using Newtonsoft.Json;
using RoboClient.Models.Robos;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RoboClient.Services
{
    public class RoboApiService
    {
        private const string BaseAddress = "http://127.0.0.1";
        private const int Port = 61231;
        private readonly HttpClient _client;

        public RoboApiService()
        {
            _client = new HttpClient();
        }

        public async Task<T> GetAsync<T>()
        {
            var response = await _client.GetAsync(new Uri($"{BaseAddress}:{Port}/api/robo"));
            response.EnsureSuccessStatusCode();
            return await ResponseToObject<T>(response);
        }

        public async Task<T> GetAsync<T>(string id)
        {
            var response = await _client.GetAsync(new Uri($"{BaseAddress}:{Port}/api/robo/{id}"));
            response.EnsureSuccessStatusCode();
            return await ResponseToObject<T>(response);
        }

        public async Task<T> PutAsync<T>(Robo robo)
        {
            var response = await _client.PutAsync(new Uri($"{BaseAddress}:{Port}/api/robo/{robo.Id}"), ToStringContent(ToJson(robo)));
            response.EnsureSuccessStatusCode();
            return await ResponseToObject<T>(response);
        }

        private async Task<T> ResponseToObject<T>(HttpResponseMessage response)
        {
            var jsonResult = await response.Content.ReadAsStringAsync();
            return ToObjectJson<T>(jsonResult);
        }      

        private static string ToJson(object objeto) => JsonConvert.SerializeObject(objeto);
        private static StringContent ToStringContent(string json) => new StringContent(json, Encoding.UTF8, "application/json");
        private static T ToObjectJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);
    }
}