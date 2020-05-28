using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jarvis_Discord.Util
{
    public static class UserUtil
    {
        public static IUser GetMessageUser(ICommandContext context, IUser user = null)
        {
            if (user is null)
                return context.User;
            return user;
        }
    }
}
