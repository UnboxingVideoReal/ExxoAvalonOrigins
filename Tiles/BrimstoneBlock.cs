using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;using Terraria.ObjectData;namespace ExxoAvalonOrigins.Tiles{	public class BrimstoneBlock : ModTile	{		public override void SetDefaults()		{			AddMapEntry(Color.LightPink);			Main.tileSolid[Type] = true;			Main.tileBlockLight[Type] = true;            Main.tileMerge[Type][ModContent.TileType<Tiles.Impgrass>()] = true;            //Main.tileMerge[Type][TileID.Ash] = true;
            Main.tileMerge[TileID.Ash][Type] = true;
            drop = ModContent.ItemType<Items.BrimstoneBlock>();            soundType = SoundID.Tink;            soundStyle = 1;        }	}}