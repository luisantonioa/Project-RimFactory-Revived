﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ProjectRimFactory.Storage.UI
{
    public class ITab_IOPortStorage : ITab_Storage
    {
        public Building_StorageUnitIOPort SelBuilding => (Building_StorageUnitIOPort)SelThing;
        public override bool IsVisible => SelBuilding.mode == StorageIOMode.Output;
        public ITab_IOPortStorage()
        {
            size = new Vector2(300f, 480f);
            this.labelKey = "TabStorage";
        }
    }
}
