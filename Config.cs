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
        public bool IsEnabled { get; set; } = false;
        [Description("Presets list. Format: preset key: text. Acceptable fields: {sender}. IMPORTANT: only lower register in preset key")]
        public Dictionary<string, string> Presets { get; set; } = new Dictionary<string, string>()
        {
            {"restart", "<color=red><b>Внимание</b></color>\n<color=yellow>Запрошен перезапуск сервера в конце раунда техником {sender}. Перезайдите, если вас кикнет</color>" }, 
            {"", "" }
        };
    }
}
