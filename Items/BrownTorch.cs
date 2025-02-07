using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items
{
	class BrownTorch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brown Torch");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Torch);
			Rectangle dims = item.modItem.GetDims();
			item.createTile = ModContent.TileType<Tiles.Torches>();
			item.width = dims.Width;
			item.height = dims.Height;
			item.placeStyle = 5;
			item.value = Item.sellPrice(0, 0, 0, 15);
			item.notAmmo = true;
			item.flame = true;
		}
		public override void HoldItem(Player player)
		{
			if (Main.rand.Next(player.itemAnimation > 0 ? 40 : 80) == 0)
			{
				Dust.NewDust(new Vector2(player.itemLocation.X + 16f * player.direction, player.itemLocation.Y - 14f * player.gravDir), 4, 4, DustID.WhiteTorch);
			}
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
			Lighting.AddLight(position, 1.51372552f, 1.16078436f, 0.9254902f);
		}

		public override void PostUpdate()
		{
			if (!item.wet)
			{
				Lighting.AddLight((int)((item.position.X + item.width / 2) / 16f), (int)((item.position.Y + item.height / 2) / 16f), 1.51372552f, 1.16078436f, 0.9254902f);
			}
		}

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}