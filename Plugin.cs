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
        public override string Name { get; } = "BroadcastPreset";
        public override string Prefix { get; } = "BCPreset";
        public override Version Version { get; } = new Version(1, 0, 0);
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
            config = null;
            config = Config;
            base.OnReloaded();
        }
    }
}
