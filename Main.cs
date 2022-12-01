﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeroTools;
using PeroTools2;
using MelonLoader;
using Logger = SkinChanger2.Logger;

namespace SkinChanger2
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            Logger.Log(Info.Name + " " + Info.Version);
            //Initialize Harmony
            HarmonyUser.Start();
        }
    }
}
