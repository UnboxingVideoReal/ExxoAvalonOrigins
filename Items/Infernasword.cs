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
	class Infernasword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infernasword");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Infernasword");
			item.damage = 44;
			item.autoReuse = true;
			item.shootSpeed = 4f;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.knockBack = 4f;
			item.useTime = 20;
			item.shoot = ModContent.ProjectileType<Projectiles.InfernoScythe>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 0, 80, 0);
			item.useAnimation = 20;
			item.height = dims.Height;
		}
	}
}