

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment2.Login
{
    public class CloudUserService : IUserService
    {
        private HttpClient client = new HttpClient();
        private string uri = "https://localhost:5001/users";

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            HttpResponseMessage response = await client.GetAsync($"{uri}?username={username}&password={password}");
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();

                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);

                return resultUser;
            }

            throw new Exception("User not found");
        }

        public async Task<User> AddUserAsync(User user)
        {
            string serialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(serialized,Encoding.UTF8,"application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(uri, content);
            Console.WriteLine(responseMessage.ToString());
            return user;
        }

        public async Task<IList<User>> getUsersAsync()
        {
            string message = await client.GetStringAsync(uri+"/all");
            List<User> result = JsonSerializer.Deserialize<List<User>>(message);
            return result;
        }

        public async Task RemoveUserAsync(string username)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{uri}?username={username}");
            Console.Write(responseMessage);
        }
    }
}