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
	class GuardianHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Guardian Hammer");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GuardianHammer");
			item.damage = 200;
			item.noUseGraphic = true;
			item.shootSpeed = 16f;
			item.rare = ItemRarityID.Cyan;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 32;
			item.knockBack = 10f;
			item.shoot = ModContent.ProjectileType<Projectiles.GuardianHammer2>();
			item.melee = true;
			item.value = Item.sellPrice(0, 25, 0, 0);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 32;
			item.height = dims.Height;
		}
	}
}