using System;
using System.Collections.Generic;
using System.Linq;
using CommandSystem;
using Exiled.API.Features;

namespace BroadcastPreset
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    class BroadcastCommand : ICommand
    {
        readonly BroadcastCommand CommandInst = new BroadcastCommand();
        readonly BroadcastPreset PluginInstance;
        BroadcastCommand ()
        {
            LoadGeneratedCommands();
        }
        public string[] Aliases { get; } = new[] { "presetbc", "prebc" };

        public string Description { get; } = "Send a preset broadcast";

        public string Command { get; } = "PresetBroadcast";
        public void LoadGeneratedCommands() { }
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if(!sender.CheckPermission(PlayerPermissions.Broadcasting))
            {
                response = "Недостаточно прав!";
                return false;
            }
            if (arguments.Count != 1)
            {
                response = "Использование: prebc <название>";
                return false;
            }
            PluginInstance.Config.Presets.TryGetValue(arguments.At(0).ToLower(), out string message);
            message.Replace("{sender}", ((CommandSender)sender).Nickname ?? "Host");
            response = "Сообщение успешно отправлено";
            return true;
        }
    }
}
