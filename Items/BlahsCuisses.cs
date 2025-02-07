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
	class BlahsCuisses : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blah's Cuisses");
			Tooltip.SetDefault("Melee weapons have a chance to instantly kill mobs | Teleportation to the\nRanged projectiles have a chance to split in two | cursor is enabled");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BlahsCuisses");
			item.defense = 50;
			item.rare = ItemRarityID.Red;
			item.width = dims.Width;
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().oblivionKill = true;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().splitProj = true;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().teleportV = true;
		}
	}
}