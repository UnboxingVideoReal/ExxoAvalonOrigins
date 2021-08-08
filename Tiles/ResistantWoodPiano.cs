using Microsoft.Xna.Framework;using Terraria;using Terraria.ID;using Terraria.ModLoader;using Terraria.ObjectData;namespace ExxoAvalonOrigins.Tiles{	public class ResistantWoodPiano : ModTile	{		public override void SetDefaults()		{			Main.tileSolidTop[Type] = true;			Main.tileFrameImportant[Type] = true;			Main.tileNoAttach[Type] = true;			Main.tileTable[Type] = true;			Main.tileLavaDeath[Type] = true;			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);			TileObjectData.newTile.CoordinateHeights = new[]{ 16, 16 };			TileObjectData.addTile(Type);			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);			AddMapEntry(new Color(233, 211, 123));            dustType = 54;
        }		public override void KillMultiTile(int i, int j, int frameX, int frameY)		{			Item.NewItem(i * 16, j * 16, 32, 16, ModContent.ItemType<Items.ResistantWoodPiano>());		}	}}