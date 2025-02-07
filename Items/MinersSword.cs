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
	class MinersSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Miner's Sword");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MinersSword");
			item.damage = 20;
			item.autoReuse = true;
			item.scale = 1.2f;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 23;
			item.knockBack = 5.5f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.useAnimation = 23;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}