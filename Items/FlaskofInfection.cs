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
	class FlaskofInfection : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flask of Infection");
			Tooltip.SetDefault("Melee attacks inflict Infected on enemies");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FlaskofInfection");
			item.useTurn = true;
			item.maxStack = 100;
			item.buffType = ModContent.BuffType<Buffs.WeaponImbuePathogen>();
			item.consumable = true;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 17;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.useAnimation = 17;
			item.height = dims.Height;
			item.buffTime = 54000;
		}
	}
}