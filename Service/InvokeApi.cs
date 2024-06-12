using CardManagementSystem.Models;
using Newtonsoft.Json;
using System.Text;

namespace CardManagementSystem.Service
{
    public class InvokeApi
    {
        private readonly HttpClient _httpClient;

        public InvokeApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> SendDeliveryDetails<T>(string baseUrl,string path, T model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{baseUrl}/{path}/",content);

            if (response.IsSuccessStatusCode)
            {
                return "Details sent successfully";
            }
            else
            {
                return "Error sending the target API";
            }
        }

    }
}
