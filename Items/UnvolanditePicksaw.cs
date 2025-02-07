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
	class UnvolanditePicksaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unvolandite Picksaw");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/UnvolanditePicksaw");
			item.damage = 30;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.15f;
			item.axe = 22;
			item.pick = 300;
			item.rare = ItemRarityID.Cyan;
			item.width = dims.Width;
			item.useTime = 9;
			item.knockBack = 5.5f;
			item.melee = true;
			item.tileBoost += 5;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 416000;
			item.useAnimation = 11;
			item.height = dims.Height;
		}
	}
}