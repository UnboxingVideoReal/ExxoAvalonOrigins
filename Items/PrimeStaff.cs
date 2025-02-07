using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExxoAvalonOrigins.Projectiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items
{
	class PrimeStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Prime Staff");
			Tooltip.SetDefault("Summons the might of Skeletron to fight for you");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/PrimeStaff");
			item.summon = true;
			item.damage = 50;
			item.shootSpeed = 14f;
			item.buffType = ModContent.BuffType<Buffs.PrimeArms>();
            item.buffTime = 3600;
			item.mana = 14;
			item.noMelee = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 30;
			item.knockBack = 6.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.PriminiCannon>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 10, 0, 0);
			item.useAnimation = 30;
			item.height = dims.Height;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
			ref float knockBack)
		{
			Projectile.NewProjectile(player.Center.X - 40f, player.Center.Y - 40f, 0f, 0f, ModContent.ProjectileType<PriminiCannon>(), damage, knockBack, player.whoAmI, 0f, 0f);
			Projectile.NewProjectile(player.Center.X + 40f, player.Center.Y - 40f, 0f, 0f, ModContent.ProjectileType<PriminiLaser>(), damage, knockBack, player.whoAmI, 0f, 0f);
			Projectile.NewProjectile(player.Center.X - 40f, player.Center.Y + 40f, 0f, 0f, ModContent.ProjectileType<PriminiSaw>(), damage, knockBack, player.whoAmI, 0f, 0f);
			Projectile.NewProjectile(player.Center.X + 40f, player.Center.Y + 40f, 0f, 0f, ModContent.ProjectileType<PriminiVice>(), damage, knockBack, player.whoAmI, 0f, 0f);
			return false;
		}
	}
}