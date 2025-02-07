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
	class GleamingTwilight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gleaming Twilight");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GleamingTwilight");
			item.damage = 90;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 11f;
			item.ranged = true;
			item.noMelee = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 15;
			item.knockBack = 4.5f;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 1000000;
			item.useAnimation = 15;
			item.height = dims.Height;
            item.UseSound = SoundID.Item5;
        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
			ref float knockBack)
		{
			for (int num188 = 0; num188 < 5; num188++)
			{
				float num189 = speedX;
				float num190 = speedY;
				num189 += (float)Main.rand.Next(-40, 41) * 0.05f;
				num190 += (float)Main.rand.Next(-40, 41) * 0.05f;
				Projectile.NewProjectile(position.X, position.Y, num189, num190, type, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			return false;
		}
	}
}