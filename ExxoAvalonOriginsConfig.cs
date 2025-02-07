﻿using System.Collections.Generic;
using System.IO;
using Terraria.ModLoader.Config;
using Newtonsoft.Json;

namespace ExxoAvalonOrigins
{
	public class ExxoAvalonOriginsConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		public struct WorldDataValues {
			public bool contagion;
			public int jungleType;
        }

		// Key value is each twld path
		[DefaultListValue(false)]
		[JsonProperty]
		private Dictionary<string, WorldDataValues> worldData = new Dictionary<string, WorldDataValues>();

		// Methods to avoid public variable getting picked up by serialiser
		public Dictionary<string, WorldDataValues> GetWorldData() { return worldData; }
		public void SetWorldData(Dictionary<string, WorldDataValues> newDict) { worldData = newDict; }
		public static void Save(ModConfig config)
		{
			Directory.CreateDirectory(ConfigManager.ModConfigPath);
			string filename = config.mod.Name + "_" + config.Name + ".json";
			string path = Path.Combine(ConfigManager.ModConfigPath, filename);
			string json = JsonConvert.SerializeObject((object)config, ConfigManager.serializerSettings);
			File.WriteAllText(path, json);
		}
	}
}
