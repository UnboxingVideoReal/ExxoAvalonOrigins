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
	class UnvolanditeGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unvolandite Greatsword");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/UnvolanditeGreatsword");
			item.damage = 109;
			item.autoReuse = true;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.knockBack = 7f;
			item.useTime = 22;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 9, 87, 65);
			item.useAnimation = 22;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}