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
	class BerserkerBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Berserker Bullet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BerserkerBullet");
			item.shootSpeed = 6f;
			item.damage = 18;
			item.ammo = AmmoID.Bullet;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.knockBack = 4f;
			item.shoot = ModContent.ProjectileType<Projectiles.BerserkerBullet>();
			item.maxStack = 2000;
			item.value = 200;
			item.height = dims.Height;
		}
	}
}