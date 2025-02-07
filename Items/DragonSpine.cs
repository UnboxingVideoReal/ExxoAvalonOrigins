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
	class DragonSpine : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon Spine");
			Tooltip.SetDefault("Summons the Dragon Lord");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/DragonSpine");
			item.consumable = true;
			item.rare = ItemRarityID.LightPurple;
			item.width = dims.Width;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.value = 0;
			item.maxStack = 20;
			item.useAnimation = 45;
			item.height = dims.Height;
        }

        public override bool CanUseItem(Player player)
        {
            if (NPC.AnyNPCs(ModContent.NPCType<NPCs.DragonLordHead>())) return false;
            return true;
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position, 0);
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.DragonLordHead>());
            return true;
        }
    }
}