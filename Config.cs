using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace BroadcastPreset
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Presets list. Format: preset key: text. Acceptable fields: {sender}. IMPORTANT: only lower register in preset key")]
        public string RestartText { get; set; } = "<color=red><b>Внимание:</b></color>\n<color=yellow>{sender} запросил перезапуск сервера в конце раунда. Перезайдите, если вас кикнет</color>";
        public string RoundEndText { get; set; } = "<color=red><b>Внимание:</b></color>\n<color=yellow>Перезапуск сервера...</color>";
    }
}
