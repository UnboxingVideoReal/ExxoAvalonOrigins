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
    class NickelHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Helmet");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/NickelHelmet");
            item.defense = 3;
            item.width = dims.Width;
            item.value = Item.sellPrice(0, 0, 0, 60);
            item.height = dims.Height;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<NickelChainmail>() && legs.type == ModContent.ItemType<NickelGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+2 defense";
            player.statDefense += 2;
        }
    }
}