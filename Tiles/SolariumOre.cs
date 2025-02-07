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
	public class SolariumOre : ModTile
	{
		public override void SetDefaults()
		{
			mineResist = 4f;
			AddMapEntry(new Color(244, 167, 0), LanguageManager.Instance.GetText("Solarium"));
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 730;
			Main.tileShine[Type] = 1150;
            drop = mod.ItemType("SolariumOre");
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 210;
            dustType = DustID.SolarFlare;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1.052549f;
            g = 0.720392168f;
            b = 0f;
        }
    }
}