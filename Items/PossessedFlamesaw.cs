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
	class PossessedFlamesaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Possessed Flamesaw");
			Tooltip.SetDefault("Can chop trees instantly");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/PossessedFlamesaw");
			item.damage = 95;
			item.noUseGraphic = true;
			item.shootSpeed = 14f;
			item.noMelee = true;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.knockBack = 9f;
			item.useTime = 15;
			item.shoot = ModContent.ProjectileType<Projectiles.PossessedFlamesaw>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}