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
	class GuideSummonDoll : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Guide Summon Doll");
			Tooltip.SetDefault("Summons the Guide");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/GuideSummonDoll");
			item.autoReuse = true;
			item.consumable = true;
			item.rare = ItemRarityID.Blue;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 30;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.maxStack = 999;
			item.useAnimation = 30;
			item.height = dims.Height;
		}

		public override bool CanUseItem(Player player) => true;

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Guide);
			return base.ConsumeItem(player);
		}
	}
}