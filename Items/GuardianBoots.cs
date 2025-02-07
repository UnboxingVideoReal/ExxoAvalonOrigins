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
	class GuardianBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Guardian Boots");
			Tooltip.SetDefault("Provides immunity to traps and knockback");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GuardianBoots");
			item.defense = 2;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.accessory = true;
			item.value = Item.sellPrice(0, 1, 44, 0);
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().trapImmune = true;
			player.noKnockback = true;
			player.noFallDmg = true;
			player.fireWalk = true;
		}
	}
}