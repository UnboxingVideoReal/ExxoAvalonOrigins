using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ObjectData;
using Terraria.Localization;

namespace ExxoAvalonOrigins.Tiles
{
	public class Beak : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry((Color.DarkOrange), LanguageManager.Instance.GetText("Beak"));
			Main.tileSolid[Type] = true;
			drop = mod.ItemType("Beak");
            soundType = SoundID.NPCHit;
            soundStyle = 2;
        }
	}
}