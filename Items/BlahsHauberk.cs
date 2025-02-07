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
	class BlahsHauberk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blah's Hauberk");
			Tooltip.SetDefault("30% decreased mana usage and increases your max number of minions by 9\nIncreases maximum mana by 800");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BlahsHauberk");
			item.defense = 100;
			item.rare = ItemRarityID.Purple;
            item.GetGlobalItem<ExxoAvalonOriginsGlobalItemInstance>().avalonRarity = AvalonRarity.Rainbow;
            item.width = dims.Width;
			item.value = Item.sellPrice(2, 0, 0, 0);
			item.height = dims.Height;
		}
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line in tooltips)
            {
                if (line.mod == "Terraria" && line.Name == "ItemName")
                {
                    line.overrideColor = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
                }
            }
        }
        public override void UpdateEquip(Player player)
		{
			player.aggro += 1000;
			player.manaCost -= 0.3f;
			player.statManaMax2 += 800;
			player.maxMinions += 12;
		}

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return (head.type == ModContent.ItemType<BlahsHeadguard>() && body.type == ModContent.ItemType<BlahsHauberk>() && legs.type == ModContent.ItemType<BlahsCuisses2>());
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Melee Stealth, Ranged Stealth, Attackers also take double full damage, and Spectre Heal";
            player.GetModPlayer<ExxoAvalonOriginsModPlayer>().doubleDamage = player.ghostHeal = player.GetModPlayer<ExxoAvalonOriginsModPlayer>().ghostSilence = player.GetModPlayer<ExxoAvalonOriginsModPlayer>().meleeStealth = player.shroomiteStealth = true;
        }
    }
}