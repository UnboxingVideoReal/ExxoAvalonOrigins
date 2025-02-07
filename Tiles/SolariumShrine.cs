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
	public class SolariumShrine : ModTile
	{
		public override void SetDefaults()
		{
			var name = CreateMapEntryName();
			name.SetDefault("Solarium Shrine");
			AddMapEntry(new Color(244, 167, 0), name);
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.addTile(Type);
			Main.tileFrameImportant[Type] = true;
			//drop = mod.ItemType("SolariumShrine");
            minPick = 9999;
        }
	}
}