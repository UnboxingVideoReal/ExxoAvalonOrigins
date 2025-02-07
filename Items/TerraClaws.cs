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
	class TerraClaws : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Claws");
			Tooltip.SetDefault("Increases melee damage and speed by 10%\nMelee attacks will burn, poison, envenom, frostburn, or ichor your enemies");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TerraClaws");
			item.rare = 12;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 15, 0, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().terraClaws = true;
			player.meleeDamage += 0.1f;
			player.meleeSpeed += 0.1f;
		}
	}
}