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
	class ReinforcedBlowpipe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reinforced Blowpipe");
			Tooltip.SetDefault("Fires a spread of two seeds\nAllows the collection of seeds for ammo");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ReinforcedBlowpipe");
			item.damage = 11;
			item.autoReuse = true;
            item.useAmmo = AmmoID.Dart;
            item.UseSound = SoundID.Item63;
            item.shootSpeed = 11f;
			item.ranged = true;
			item.rare = ItemRarityID.Blue;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 40;
			item.knockBack = 3.25f;
			item.shoot = ProjectileID.PurificationPowder;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 10000;
			item.useAnimation = 40;
			item.height = dims.Height;
            item.UseSound = SoundID.Item5;
        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
			ref float knockBack)
		{
			for (int num197 = 0; num197 < 2; num197++)
			{
				float num198 = speedX;
				float num199 = speedY;
				num198 += (float)Main.rand.Next(-35, 36) * 0.05f;
				num199 += (float)Main.rand.Next(-35, 36) * 0.05f;
				Projectile.NewProjectile(position.X, position.Y, num198, num199, type, damage, knockBack, player.whoAmI, 0f, 0f);
			}

			return false;
		}
	}
}