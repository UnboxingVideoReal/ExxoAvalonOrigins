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
	[AutoloadEquip(EquipType.Head)]
	class BlahsHeadguard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blah's Headguard");
			Tooltip.SetDefault("35% increased damage\n11% increased critical strike chance");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/BlahsHeadguard");
			item.defense = 100;
			item.rare = 12;
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
        public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BlahsHauberk>() && legs.type == ModContent.ItemType<BlahsCuisses2>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().blahArmor = true;
			player.setBonus = "Melee Stealth, Ranged Stealth, Attackers also take double full damage, and Spectre Heal";
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().meleeStealth = true;
			player.shroomiteStealth = true;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().doubleDamage = true;
			player.ghostHeal = true;
			//player.thorns = true;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().ghostSilence = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.35f;
			player.magicDamage += 0.35f;
			player.rangedDamage += 0.35f;
			player.meleeCrit += 11;
			player.rangedCrit += 11;
			player.magicCrit += 11;
		}
	}
}