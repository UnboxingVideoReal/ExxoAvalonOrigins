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
	public class Staminastone : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(Color.SeaGreen, LanguageManager.Instance.GetText("Staminastone"));
			Main.tileSolid[Type] = true;
			drop = mod.ItemType("Staminastone");
            soundType = SoundID.Tink;
            soundStyle = 1;
            dustType = DustID.Grass;
        }
	}
}