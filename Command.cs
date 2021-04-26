using System;
using MEC;
using CommandSystem;
using Exiled.API.Features;

namespace BroadcastPreset
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class BroadcastCommand : ICommand
    { 
        public string[] Aliases { get; } = new[] { "presetbc", "prebc" };
        public string Description { get; } = "Send a preset broadcast";
        public string Command { get; } = "PresetBroadcast";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if(!sender.CheckPermission(PlayerPermissions.Broadcasting))
            {
                response = "Недостаточно прав!";
                return false;
            }
            if (arguments.Count != 1)
            {
                response = "Использование: prebc <название> <опциональное_дополнение>";
                return false;
            }
            if(!BroadcastPreset.config.Presets.TryGetValue(arguments.At(0).ToLower(), out string message))
            {
                response = "Пресет не найден";
                return false;
            }
            message = message.Replace("{sender}", ((CommandSender)sender)?.Nickname ?? "Host");
            Map.Broadcast(10, message);
            string message_add = arguments.At(1);
            if (!String.IsNullOrEmpty(message_add))
            {
                Timing.CallDelayed(10f, () => Map.Broadcast(10, message));
            }            
            response = "Сообщение успешно отправлено";
            return true;
        }
    }
}
