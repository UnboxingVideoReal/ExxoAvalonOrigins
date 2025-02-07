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
	class TheBeak : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Beak");
			Tooltip.SetDefault("Summons Desert Beak");
		}

		public override void SetDefaults()
		{
			//Rectangle dims = ExxoAvalonOrigins.getDims("Items/TheBeak");
			item.consumable = true;
			item.width = 32;
			item.useTime = 40;
			item.maxStack = 20;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.useAnimation = 40;
			item.height = 28;
        }

        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(ModContent.NPCType<NPCs.DesertBeak>());
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.DesertBeak>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}