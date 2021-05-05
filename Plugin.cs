using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.Handlers;

namespace BroadcastPreset
{
    public class BroadcastPreset : Plugin<Config>
    {
        public override string Author { get; } = "Chris \"Irvis\" Praison";
        public override string Name { get; } = "RestartBroadcastSystem";
        public override string Prefix { get; } = "RestartAnnoncer";
        public override Version Version { get; } = new Version(2, 0, 0);
        public static Config config;
        public override void OnEnabled()
        {
            config = Config;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            config = null;
            base.OnDisabled();
        }
        public void OnReload()
        {
            base.OnReloaded();
        }
    }
}
