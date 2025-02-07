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
	class RottenBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Bullet");
			Tooltip.SetDefault("Slow speed, low range, but high damage and knockback");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/RottenBullet");
			item.damage = 15;
			item.shootSpeed = 1.5f;
			item.ammo = AmmoID.Bullet;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.knockBack = 16f;
			item.shoot = ModContent.ProjectileType<Projectiles.RottenBullet>();
			item.value = 10;
			item.maxStack = 2000;
			item.height = dims.Height;
		}
	}
}