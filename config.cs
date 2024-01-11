﻿using BepInEx.Configuration;
using BepInEx.Logging;
using UnityEngine;

namespace PersistentShipObjects {
    public class Config {
        public static ConfigEntry<Dictionary<String, VivsTrans>>? shipObjectVivTransforms;

        public Config(ConfigFile cfg) {
            shipObjectVivTransforms = cfg.Bind(
                "General", // Config section
                "shipObjectVivTransforms", // Key of this config
                new Dictionary<String, VivsTrans> { { "testName", new VivsTrans(new Vector3(0, 0, 0), Quaternion.identity) } }, // Default value
                "Object transforms configuration" // Description
            );
        }
    }
}
