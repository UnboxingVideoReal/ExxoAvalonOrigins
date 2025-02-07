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
	class HallowedGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Greatsword");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HallowedGreatsword");
			item.damage = 43;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.5f;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTime = 26;
			item.knockBack = 2f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 5, 55, 0);
			item.useAnimation = 26;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}