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
	class TomeoftheDistantPast : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of the Distant Past");
			Tooltip.SetDefault("Summons a bone barrage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TomeoftheDistantPast");
			item.magic = true;
			item.damage = 30;
			item.autoReuse = true;
			item.shootSpeed = 7f;
			item.crit += -1;
			item.mana = 6;
			item.noMelee = true;
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.useTime = 15;
			item.knockBack = 4f;
			item.shoot = ModContent.ProjectileType<Projectiles.Bones>();
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 27000;
			item.useAnimation = 15;
			item.height = dims.Height;
		}
	}
}