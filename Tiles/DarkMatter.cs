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

namespace ExxoAvalonOrigins.Tiles
{
	public class DarkMatter : ModTile
	{
		public override void SetDefaults()
		{
			AddMapEntry(new Color(135, 15, 170));
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = mod.ItemType("DarkMatterBlock");
            soundType = SoundID.Tink;
            soundStyle = 1;
            dustType = ModContent.DustType<Dusts.DarkMatterDust>();
        }

        public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (!fail)
            {
                ExxoAvalonOriginsWorld.WorldDarkMatterTiles--;
            }
            base.KillTile(i, j, ref fail, ref effectOnly, ref noItem);
        }
    }
}