using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;
using Exiled.API.Features;
using ServerEv = Exiled.Events.Handlers.Server;

namespace BroadcastPreset
{
    public class BroadcastPreset : Plugin<Config>
    {
        public override string Author { get; } = "Chris \"Irvis\" Praison";
        public override string Name { get; } = "RestartBroadcastSystem";
        public override string Prefix { get; } = "RestartAnnoncer";
        public override Version Version { get; } = new Version(2, 1, 0);
        public static Config config;
        public static bool IsRestarting;
        public override void OnEnabled()
        {
            config = Config;
            ServerEv.EndingRound += AnnonceRestart;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            config = null;
            ServerEv.EndingRound -= AnnonceRestart;
            base.OnDisabled();
        }
        public void OnReload()
        {
            base.OnReloaded();
        }
        public void AnnonceRestart(EndingRoundEventArgs ev)
        {
            if (IsRestarting)
            {
                Map.Broadcast(10, config.RoundEndText);
            }
        }
    }
}
