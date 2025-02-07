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
	class TheGoldenFlames : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Golden Flames");
			Tooltip.SetDefault("'The flames are made of gold!'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TheGoldenFlames");
			item.magic = true;
			item.damage = 72;
			item.channel = true;
			item.shootSpeed = 10f;
			item.crit += 11;
			item.mana = 14;
			item.noMelee = true;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.knockBack = 7f;
			item.useTime = 50;
			item.shoot = ModContent.ProjectileType<Projectiles.GoldenFire>();
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 250000;
			item.useAnimation = 50;
			item.height = dims.Height;
		}
	}
}