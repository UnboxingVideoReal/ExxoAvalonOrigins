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
	class DurataniumOmegaShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duratanium Omega Shield");
			Tooltip.SetDefault("Increases defense and regenerates life when struck\nGreatly slows the effects of damage over time debuffs");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DurataniumOmegaShield");
			item.defense = 4;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.value = 100000;
			item.accessory = true;
			item.height = dims.Height;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().incDef = true;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().regenStrike = true;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().frontReflect = true;
			player.noKnockback = true;
		}
	}
}