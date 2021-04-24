using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using UnityEngine;
using Interactables.Interobjects.DoorUtils;
using CommandSystem;

namespace BroadcastPreset
{
    public class Handlers
    {
        readonly BroadcastPreset PluginInstance;
        public Handlers(BroadcastPreset Plug)
        {
            PluginInstance = Plug;
        }
    }
}
