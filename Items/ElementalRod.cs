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
	class ElementalRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elemental Rod");
			Tooltip.SetDefault("Will inflict debuffs");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ElementalRod");
			item.magic = true;
			item.damage = 45;
			item.channel = true;
			item.shootSpeed = 9f;
			item.mana = 19;
			item.crit += 16;
			item.rare = ItemRarityID.Yellow;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 23;
			item.knockBack = 4f;
			item.shoot = ModContent.ProjectileType<Projectiles.ElementOrb>();
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 23;
			item.height = dims.Height;
		}
	}
}