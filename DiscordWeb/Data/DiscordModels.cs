using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiscordWeb.Data
{
    public class DiscordEntry
    {
        [Key]
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public string MessageLink { get; set; }
    }
}
