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
	class FeroziumBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ferozium Bullet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FeroziumBullet");
			item.shootSpeed = 5.25f;
			item.damage = 15;
			item.ammo = AmmoID.Bullet;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.knockBack = 5f;
			item.shoot = ModContent.ProjectileType<Projectiles.FeroziumBullet>();
			item.maxStack = 2000;
			item.value = 200;
			item.height = dims.Height;
		}
	}
}