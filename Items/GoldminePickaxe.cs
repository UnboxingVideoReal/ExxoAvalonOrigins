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
	class GoldminePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goldmine Pickaxe");
			Tooltip.SetDefault("Able to mine Hellstone");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GoldminePickaxe");
			item.UseSound = SoundID.Item1;
			item.damage = 10;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.15f;
			item.pick = 75;
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.useTime = 13;
			item.knockBack = 3f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 0, 36, 0);
			item.useAnimation = 21;
			item.height = dims.Height;
		}
	}
}