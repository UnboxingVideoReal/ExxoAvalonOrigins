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
	public class NaquadahOre : ModTile
	{
		public override void SetDefaults()
		{
			mineResist = 3f;
			AddMapEntry(Color.Blue, LanguageManager.Instance.GetText("Naquadah"));
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileValue[Type] = 635;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 900;
            drop = mod.ItemType("NaquadahOre");
            soundType = SoundID.Tink;
            soundStyle = 1;
            minPick = 110;
            dustType = ModContent.DustType<Dusts.NaquadahDust>();
        }

        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }
}