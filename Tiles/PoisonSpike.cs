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
	public class PoisonSpike : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(95, 95, 36), LanguageManager.Instance.GetText("Poison Spike"));
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = mod.ItemType("PoisonSpike");
            soundType = SoundID.Tink;
            soundStyle = 1;
            dustType = DustID.Grass;
        }
	}
}