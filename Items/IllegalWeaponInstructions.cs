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
	class IllegalWeaponInstructions : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Illegal Weapon Instructions");
			Tooltip.SetDefault("'Read if you dare'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/IllegalWeaponInstructions");
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.value = 50;
			item.maxStack = 99;
			item.height = dims.Height;
		}
	}
}