using System;
using MEC;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Collections.Generic;

namespace BroadcastPreset
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class BroadcastCommand : ICommand
    { 
        public string[] Aliases { get; } = new[] { "prebc" };
        public string Description { get; } = "Send a preset broadcast";
        public string Command { get; } = "restartannonce";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if(!sender.CheckPermission(PlayerPermissions.Broadcasting))
            {
                response = "Недостаточно прав!";
                return false;
            }
            string message = BroadcastPreset.config.RestartText;
            message = message.Replace("{sender}", ((CommandSender)sender)?.Nickname ?? "Host");
            Map.Broadcast(10, message);
            BroadcastPreset.IsRestarting = true;
            response = "Сообщение успешно отправлено";
            return true;
        }
    }
}