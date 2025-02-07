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
	class Electrobullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Electrobullet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Electrobullet");
			item.shootSpeed = 5.25f;
			item.damage = 13;
			item.ammo = AmmoID.Bullet;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.knockBack = 5f;
			item.shoot = ModContent.ProjectileType<Projectiles.Electrobullet>();
			item.maxStack = 2000;
			item.value = 400;
			item.height = dims.Height;
		}
	}
}