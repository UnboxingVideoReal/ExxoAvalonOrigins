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
	class DurataniumPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duratanium Pickaxe");
			Tooltip.SetDefault("Can mine Mythril, Orichalcum, and Naquadah");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DurataniumPickaxe");
			item.damage = 10;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1f;
			item.pick = 110;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 20;
			item.knockBack = 1f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 1, 40, 0);
			item.useAnimation = 20;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}