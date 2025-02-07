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
	class SackofToys : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sack of Toys");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SackofToys");
			item.damage = 45;
			item.color = Color.Red;
			item.shootSpeed = 14f;
			item.ranged = true;
			item.noMelee = true;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTime = 24;
			item.knockBack = 4.5f;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.useAnimation = 24;
			item.height = dims.Height;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
			ref float knockBack)
		{
			int num164 = Main.rand.Next(14);
			if (num164 == 0)
			{
				for (int num165 = 0; num165 < 2; num165++)
				{
					float num166 = speedX;
					float num167 = speedY;
					num166 += (float)Main.rand.Next(-30, 31) * 0.05f;
					num167 += (float)Main.rand.Next(-30, 31) * 0.05f;
					Projectile.NewProjectile(position.X, position.Y, num166, num167, ProjectileID.WoodenArrowFriendly, damage, knockBack, player.whoAmI, 0f, 0f);
				}
			}
			else if (num164 == 1)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FireArrow, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 2)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Shuriken, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 3)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.JestersArrow, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 4)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.EnchantedBoomerang, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 5)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Bullet, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 6)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BallofFire, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 7)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BallOHurt, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 8)
			{
				for (int num168 = 0; num168 < 2; num168++)
				{
					float num169 = speedX;
					float num170 = speedY;
					num169 += (float)Main.rand.Next(-30, 31) * 0.05f;
					num170 += (float)Main.rand.Next(-30, 31) * 0.05f;
					Projectile.NewProjectile(position.X, position.Y, num169, num170, ProjectileID.WaterBolt, damage, knockBack, player.whoAmI, 0f, 0f);
				}
			}
			else if (num164 == 9)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Grenade, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 10)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ThornChakram, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 11)
			{
				int num171 = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.HarpyFeather, damage, knockBack, player.whoAmI, 0f, 0f);
				Main.projectile[num171].hostile = false;
				Main.projectile[num171].friendly = true;
			}
			else if (num164 == 12)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DemonScythe, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			else if (num164 == 13)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.PoisonedKnife, damage, knockBack, player.whoAmI, 0f, 0f);
			}

			return false;
		}
	}
}