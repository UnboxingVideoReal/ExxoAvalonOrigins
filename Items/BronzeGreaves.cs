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
    class BronzeGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Greaves");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/BronzeGreaves");
            item.defense = 2;
            item.width = dims.Width;
            item.value = Item.sellPrice(0, 0, 0, 40);
            item.height = dims.Height;
        }
    }
}