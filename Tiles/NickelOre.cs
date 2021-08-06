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
	public class NickelOre : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(82, 112, 122), LanguageManager.Instance.GetText("Nickel"));
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileShine[Type] = 1150;
            Main.tileSpelunker[Type] = true;
			drop = ModContent.ItemType<Items.NickelOre>();
            soundType = SoundID.Tink;
            soundStyle = 1;
            dustType = 37;
		}
	}
}