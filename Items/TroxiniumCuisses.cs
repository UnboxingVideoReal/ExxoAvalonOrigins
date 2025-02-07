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
	[AutoloadEquip(EquipType.Legs)]
	class TroxiniumCuisses : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Troxinium Cuisses");
			Tooltip.SetDefault("5% increased critical strike chance");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TroxiniumCuisses");
			item.defense = 13;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 2, 30, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicCrit += 5;
			player.rangedCrit += 5;
			player.meleeCrit += 5;
		}
	}
}