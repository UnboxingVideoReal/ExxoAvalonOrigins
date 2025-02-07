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
	class EnchantedShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Shuriken");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/EnchantedShuriken");
			item.damage = 13;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.shootSpeed = 9f;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Green;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 15;
			item.shoot = ModContent.ProjectileType<Projectiles.EnchantedShuriken>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 30;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}