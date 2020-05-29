using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Jarvis_Discord.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jarvis_Discord.Modules
{
    public class VoiceCommands : ModuleBase<SocketCommandContext>
    {
        //[Command("join", true)]
        //public async Task JoinCommand()
        //{
        //    var channel = Context.Channel;
        //    await Context.Client.GetChannel("").joNEm 
        //}

        [Command("join", true)]
        public async Task JoinCommand(string link = null)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                await ReplyAsync("Você precisar me passar um link!");
                return;
            }

            var user = UserUtil.GetMessageUser(Context);
            var voiceState = (user as IVoiceState);

            if(voiceState.VoiceChannel is null)
            {
                await ReplyAsync($"{user.Mention}. Você precisa estar em um canal de voz para tocar músicas!");
                return;
            }

            var voiceChannel = Context.Guild.VoiceChannels.Where(x => x.Id == voiceState.VoiceChannel.Id).FirstOrDefault();

            if(voiceChannel is null) 
            {
                await ReplyAsync($"{user.Mention}. Não encontrei o canal de voz em que você está! Tente novamente.");
                return;
            }

            await voiceChannel.ConnectAsync();
            //if(channelUsers.Any(x => !x.Any(x => x.Id == user.Id))) 
            //{
            //    await ReplyAsync("Bolo de fubá");
            //}



            //var channel = Context.Channel;
            //await Context.Client.GetChannel("").jo
        }
    }
}
