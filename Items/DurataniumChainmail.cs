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
	class DurataniumChainmail : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duratanium Chainmail");
			Tooltip.SetDefault("5% increased damage");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DurataniumChainmail");
			item.defense = 10;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.value = Item.sellPrice(0, 1, 60, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.05f;
			player.rangedDamage += 0.05f;
			player.minionDamage += 0.05f;
			player.meleeDamage += 0.05f;
		}
	}
}