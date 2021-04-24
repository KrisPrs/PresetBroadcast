using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.Handlers;

namespace PluginPreset
{
    public class PluginPreset : Plugin<Config>
    {
        public override string Author { get; } = "Chris \"Irvis\" Praison";
        public override string Name { get; } = "BroadcastPreset";
        public override string Prefix { get; } = "BCPreset";
        public override Version Version { get; } = new Version(1, 0, 0);
        public Handlers Ev;
        public override void OnEnabled()
        {
            base.OnEnabled();
            Ev = new Handlers(this);

        }
        public override void OnDisabled()
        {

            base.OnDisabled();
            Ev = null;
        }
        public void OnReload()
        {
            base.OnReloaded();
        }
    }
}
