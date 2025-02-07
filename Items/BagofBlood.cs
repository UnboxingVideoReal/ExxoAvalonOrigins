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
	class BagofBlood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bag of Blood");
			Tooltip.SetDefault("Blood particles cover you when you move");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BagofBlood");
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.accessory = true;
			item.vanity = true;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.height = dims.Height;
			item.GetGlobalItem<ExxoAvalonOriginsGlobalItemInstance>().updateInvisibleVanity = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (player.controlRight)
			{
				var num18 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.TheDestoryer, 0f, 0f, 100,
					Color.White, 0.9f);
				Main.dust[num18].noGravity = true;
				var num19 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White,
					1.5f);
				Main.dust[num19].noGravity = true;
			}

			if (player.controlLeft)
			{
				var num20 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.TheDestoryer, 0f, 0f, 100,
					Color.White, 0.9f);
				Main.dust[num20].noGravity = true;
				var num21 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White,
					1.5f);
				Main.dust[num21].noGravity = true;
			}

			if (player.controlJump)
			{
				var num22 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.TheDestoryer, 0f, 0f, 100,
					Color.White, 0.9f);
				Main.dust[num22].noGravity = true;
				var num23 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.Blood, 0f, 0f, 100,
					Color.White, 1.5f);
				Main.dust[num23].noGravity = true;
			}

			if (player.controlRight)
			{
				var num61 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.TheDestoryer, 0f, 0f, 100,
					Color.White, 0.9f);
				Main.dust[num61].noGravity = true;
				var num62 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White,
					1.5f);
				Main.dust[num62].noGravity = true;
			}

			if (player.controlLeft)
			{
				var num63 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.TheDestoryer, 0f, 0f, 100,
					Color.White, 0.9f);
				Main.dust[num63].noGravity = true;
				var num64 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White,
					1.5f);
				Main.dust[num64].noGravity = true;
			}

			if (player.controlJump)
			{
				var num65 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.TheDestoryer, 0f, 0f, 100,
					Color.White, 0.9f);
				Main.dust[num65].noGravity = true;
				var num66 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.Blood, 0f, 0f, 100,
					Color.White, 1.5f);
				Main.dust[num66].noGravity = true;
			}
		}

		public override void UpdateVanity(Player player, EquipType type)
		{
			if (player.controlRight)
			{
				var num18 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.TheDestoryer, 0f, 0f, 100, Color.White, 0.9f);
				Main.dust[num18].noGravity = true;
				var num19 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White, 1.5f);
				Main.dust[num19].noGravity = true;
			}
			if (player.controlLeft)
			{
				var num20 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.TheDestoryer, 0f, 0f, 100, Color.White, 0.9f);
				Main.dust[num20].noGravity = true;
				var num21 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White, 1.5f);
				Main.dust[num21].noGravity = true;
			}
			if (player.controlJump)
			{
				var num22 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.TheDestoryer, 0f, 0f, 100, Color.White, 0.9f);
				Main.dust[num22].noGravity = true;
				var num23 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.Blood, 0f, 0f, 100, Color.White, 1.5f);
				Main.dust[num23].noGravity = true;
			}
			if (player.controlRight)
			{
				var num61 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.TheDestoryer, 0f, 0f, 100, Color.White, 0.9f);
				Main.dust[num61].noGravity = true;
				var num62 = Dust.NewDust(player.position, player.width - 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White, 1.5f);
				Main.dust[num62].noGravity = true;
			}
			if (player.controlLeft)
			{
				var num63 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.TheDestoryer, 0f, 0f, 100, Color.White, 0.9f);
				Main.dust[num63].noGravity = true;
				var num64 = Dust.NewDust(player.position, player.width + 20, player.height, DustID.Blood, 0f, 0f, 100, Color.White, 1.5f);
				Main.dust[num64].noGravity = true;
			}
			if (player.controlJump)
			{
				var num65 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.TheDestoryer, 0f, 0f, 100, Color.White, 0.9f);
				Main.dust[num65].noGravity = true;
				var num66 = Dust.NewDust(player.position, player.width + 20, player.height + 20, DustID.Blood, 0f, 0f, 100, Color.White, 1.5f);
				Main.dust[num66].noGravity = true;
			}
		}
	}
}