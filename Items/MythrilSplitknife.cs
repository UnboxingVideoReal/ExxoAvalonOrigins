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
	class MythrilSplitknife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mythril Splitknife");
			Tooltip.SetDefault("Splits into three knives");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MythrilSplitknife");
			item.noUseGraphic = true;
			item.damage = 25;
			item.maxStack = 999;
			item.shootSpeed = 10f;
			item.ranged = true;
			item.consumable = true;
			item.noMelee = true;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 18;
			item.knockBack = 2f;
			item.shoot = ModContent.ProjectileType<Projectiles.MythrilKnife>();
			item.value = 250;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 18;
			item.height = dims.Height;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
			ref float knockBack)
		{
			for (int num215 = 0; num215 < 3; num215++)
			{
				float num216 = speedX;
				float num217 = speedY;
				num216 += (float)Main.rand.Next(-40, 41) * 0.05f;
				num217 += (float)Main.rand.Next(-40, 41) * 0.05f;
				Projectile.NewProjectile(position.X, position.Y, num216, num217, type, damage, knockBack, player.whoAmI, 0f, 0f);
			}

			return false;
		}
	}
}