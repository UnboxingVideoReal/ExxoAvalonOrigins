using Microsoft.Xna.Framework;
			Main.tileMerge[Type][TileID.Stone] = true;
			Main.tileMerge[TileID.Stone][Type] = true;
			Main.tileMerge[Type][ModContent.TileType<TropicalMud>()] = true;
			Main.tileMerge[ModContent.TileType<TropicalMud>()][Type] = true;
			drop = mod.ItemType("LoamstoneBrick");
        }

