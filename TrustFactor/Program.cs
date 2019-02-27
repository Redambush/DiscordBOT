using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace TrustFactor
{
    class Program
    {
        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();
        
    }
}
