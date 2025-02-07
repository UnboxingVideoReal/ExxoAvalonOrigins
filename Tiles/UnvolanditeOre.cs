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
	public class UnvolanditeOre : ModTile
	{
		public override void SetDefaults()
		{
			mineResist = 8f;
			AddMapEntry(new Color(78, 79, 41), LanguageManager.Instance.GetText("Unvolandite"));
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 840;
            Main.tileBlockLight[Type] = true;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 2100;
            drop = mod.ItemType("UnvolanditeOre");
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 250;
        }
        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }
}