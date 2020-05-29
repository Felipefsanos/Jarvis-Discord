using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Jarvis_Discord.Util
{
    public static class StreamUtil
    {
        public static Process CreateStream()
        {
            return Process.Start(new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = @"-hide_banner -loglevel panic -i C:\\Users\\lipe2\\Documents\\Projetos\\Jarvis-Discord\\Jarvis-Discord\\bin\\Debug\\netcoreapp3.1\\ -ac 2 -f s16le -ar 48000 pipe:1",
                UseShellExecute = false,
                RedirectStandardOutput = true,
            });
        }
    }
}
