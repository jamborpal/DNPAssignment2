using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment2.Data
{
    public class CloudAdultService : IAdultService
    {
        private HttpClient client = new HttpClient();
        private String uri = "https://localhost:5001/adults";

        public CloudAdultService()
        {
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            string message = await client.GetStringAsync(uri);
            IList<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string serialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(serialized, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(uri, content);
            Console.WriteLine(responseMessage.ToString());
        }

        public async Task RemoveAdultAsync(int id)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{uri}/{id}");
            Console.Write(responseMessage);
        }

        public async void EditAdult()
        {
            throw new System.NotImplementedException();
        }
    }
}