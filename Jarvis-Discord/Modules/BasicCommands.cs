using Discord;
using Discord.Commands;
using Jarvis_Discord.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis_Discord.Modules
{
    public class BasicCommands : ModuleBase<SocketCommandContext>
    {
        [Command("ping", true)]
        [Alias("p")]
        public async Task PingCommand() 
        {
            await ReplyAsync("pong");
        }

        [Command("user-info", false)]
        [Alias("u-i")]
        public async Task PingCommand(Discord.IUser user = null)
        {
            user = UserUtil.GetMessageUser(Context, user);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Criado em: {user.CreatedAt.DateTime}");
            stringBuilder.AppendLine(user.IsBot ? "Usuário é bot" : "Usuário não é um bot");
            stringBuilder.AppendLine($"Status: {user.Status}");

            var embed = new EmbedBuilder
            {
                Title = $"{user.Username}",
                ImageUrl = user.GetAvatarUrl(),
                Color = Color.DarkBlue, 
                Description = stringBuilder.ToString()
            };

            await ReplyAsync(embed: embed.Build());
        }
    }
}
