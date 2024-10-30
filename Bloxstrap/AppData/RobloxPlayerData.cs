﻿using Bloxstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloxstrap.AppData
{
    public class RobloxPlayerData : CommonAppData, IAppData
    {
        public string ProductName => "Roblox";

        public string BinaryType => "WindowsPlayer";

        public string RegistryName => "RobloxPlayer";

        public override string ExecutableName => App.Settings.Prop.RenameClientToEuroTrucks2 ? "eurotrucks2.exe" : "RobloxPlayerBeta.exe";
        public string StartEvent => "www.roblox.com/robloxStartedEvent";
        public override string Directory => Path.Combine(Paths.Roblox, "Player");
        public string OldDirectory => Path.Combine(Paths.Roblox, "Player.old");

        public AppState State => App.State.Prop.Player;

        public override IReadOnlyDictionary<string, string> PackageDirectoryMap { get; set; } = new Dictionary<string, string>()
        {
            { "RobloxApp.zip", @"" }
        };
    }
}
