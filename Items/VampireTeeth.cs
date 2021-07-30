﻿using Microsoft.Xna.Framework;
    class VampireTeeth : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vampire Teeth");
            Tooltip.SetDefault("Grants the ability for true melee attacks to lifesteal");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/VampireTeeth");
            item.rare = 8;
            item.width = dims.Width;
            item.accessory = true;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.height = dims.Height;
        }
    }