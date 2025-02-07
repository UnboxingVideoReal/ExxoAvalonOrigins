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
	[AutoloadEquip(EquipType.Body)]
	class BerserkerBodyarmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Berserker Bodyarmor");
			Tooltip.SetDefault("Enemies are more likely to target you"
				+ "\nTaking heavy damage will give you the 'Berserk!' buff"
				+ "\n'Berserk!' gives a massive buff to the critical strike damage of true melee weapons");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BerserkerBodyarmor");
			item.defense = 42;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 60, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.aggro += 600;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().goBerserk = true;
		}
	}
}