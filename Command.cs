using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandSystem;

namespace BroadcastPreset
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class BroadcastCommand : ICommand
    {
        public string[] Aliases { get; } = new[] { "presetbc", "prebc" };

        public string Description { get; } = "Send a preset broadcast";

        public string Command { get; } = "PresetBroadcast";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            response = "";
            return true;
        }
    }
}
