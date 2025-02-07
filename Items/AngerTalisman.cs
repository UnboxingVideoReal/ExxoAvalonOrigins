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
	[AutoloadEquip(EquipType.Neck)]
	class AngerTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anger Talisman");
			Tooltip.SetDefault("27% increased damage and minus 10 defense\n'Can you say, \"Grrr!\"?'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/AngerTalisman");
			item.defense = -10;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 9, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage += 0.27f;
			player.rangedDamage += 0.27f;
			player.magicDamage += 0.27f;
			player.minionDamage += 0.27f;
		}
	}
}