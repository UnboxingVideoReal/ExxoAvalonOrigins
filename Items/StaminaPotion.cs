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
	class StaminaPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stamina Potion");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/StaminaPotion");
			item.consumable = true;
			item.rare = ItemRarityID.Green;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 17;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.maxStack = 50;
			item.value = 900;
			item.useAnimation = 17;
			item.height = dims.Height;
            item.UseSound = SoundID.Item3;
        }
	}
}