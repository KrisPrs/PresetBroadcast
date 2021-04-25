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
        public override void OnEnabled()
        {
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }
        public void OnReload()
        {
            base.OnReloaded();
        }
    }
}
