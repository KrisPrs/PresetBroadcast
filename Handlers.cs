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

namespace PluginPreset
{
    public class Handlers
    {
        PluginPreset PluginInstance;
        public Handlers(PluginPreset Plug)
        {
            PluginInstance = Plug;
        }
    }
}
