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
	class VorazylcumPicksaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vorazylcum Picksaw");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VorazylcumPicksaw");
			item.damage = 30;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.15f;
			item.axe = 25;
			item.pick = 310;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.useTime = 13;
			item.knockBack = 5.5f;
			item.melee = true;
			item.tileBoost += 6;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 516000;
			item.useAnimation = 15;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}