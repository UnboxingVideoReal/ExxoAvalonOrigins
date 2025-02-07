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
	public class OblivionOre : ModTile
	{
		public override void SetDefaults()
		{
			mineResist = 8f;
			AddMapEntry(new Color(127, 0, 110), LanguageManager.Instance.GetText("Oblivion Ore"));
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 900;
            drop = mod.ItemType("OblivionOre");
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 300;
            dustType = DustID.Adamantine;
        }

        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }
}