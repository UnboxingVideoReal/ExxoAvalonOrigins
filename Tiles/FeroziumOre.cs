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
	public class FeroziumOre : ModTile
	{
		public override void SetDefaults()
		{
			mineResist = 2f;
			AddMapEntry(new Color(0, 0, 250), LanguageManager.Instance.GetText("Ferozium"));
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 690;
            Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 1150;
            drop = mod.ItemType("FeroziumOre");
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 180;
            dustType = DustID.Ultrabright;
        }
        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }
}