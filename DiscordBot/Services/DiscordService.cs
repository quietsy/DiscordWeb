using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DiscordBot.Services
{
    public class DiscordEntry
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public string MessageLink { get; set; }
    }

    public class DiscordService
    {
        private readonly HttpClient _http;

        public DiscordService(HttpClient http)
            => _http = http;

        public async Task AddDiscordEntryAsync(string channel, string user, string text, string link)
        {
            string json = JsonConvert.SerializeObject(new
            {
                channelName = channel,
                username = user,
                message = text,
                messageLink = link
            });

            var discordweb = Environment.GetEnvironmentVariable("discordweb");
            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            await _http.PostAsync(discordweb, content);
        }

        public async Task<DiscordEntry> GetDiscordEntryByIdAsync(int id)
        {
            var discordweb = Environment.GetEnvironmentVariable("discordweb");
            var idUriPath = discordweb + "/" + id.ToString();
            var response = await _http.GetAsync(idUriPath);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DiscordEntry>(responseBody);
        }

        public async Task<DiscordEntry> GetDiscordEntryByMessageAsync(string name)
        {
            string json = JsonConvert.SerializeObject(name);

            var discordweb = Environment.GetEnvironmentVariable("discordweb");
            var idUriPath = discordweb + "/getbymessage";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(idUriPath),
                Content = new StringContent(json.ToString(), Encoding.UTF8, "application/json"),
            };

            var response = await _http.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DiscordEntry>(responseBody);
        }

        public async Task DeleteDiscordEntryAsync(int id)
        {
            var discordweb = Environment.GetEnvironmentVariable("discordweb");
            var idUriPath = discordweb + "/" + id.ToString();
            var response = await _http.DeleteAsync(idUriPath);
            response.EnsureSuccessStatusCode();
        }
    }
}