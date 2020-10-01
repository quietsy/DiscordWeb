using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Services;

namespace DiscordBot.Modules
{
    public class PublicModule : ModuleBase<SocketCommandContext>
    {
        public DiscordService service { get; set; }

        [Command("add")]
        [Alias("a", "recommend")]
        public async Task AddAsync([Remainder] string text)
        {
            var link = Context.Message.GetJumpUrl().Replace("https", "discord");
            var user = Context.User.ToString();
            var channel = Context.Channel.ToString();
            await service.AddDiscordEntryAsync(channel, user, text, link);
            await Context.Message.AddReactionAsync(new Emoji("👍"));
        }

        [Command("del")]
        [Alias("d", "remove", "r")]
        public async Task DeleteAsync([Remainder] string text)
        {
            var user = Context.User as SocketGuildUser;
            var channel = Context.Channel as SocketGuildChannel;
            var isAllowed = user.GetPermissions(channel).ManageMessages;

            var isNumeric = int.TryParse(text, out int id);
            DiscordEntry entry;

            if (isNumeric)
                entry = service.GetDiscordEntryByIdAsync(id).Result;
            else
                entry = service.GetDiscordEntryByMessageAsync(text).Result;

            if (Context.User.ToString() == entry.Username || isAllowed)
            {
                await service.DeleteDiscordEntryAsync(entry.Id);
            }

            await Context.Message.AddReactionAsync(new Emoji("👍"));
        }
    }
}