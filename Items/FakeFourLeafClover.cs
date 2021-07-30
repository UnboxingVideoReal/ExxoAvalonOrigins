﻿using Microsoft.Xna.Framework;
    class FakeFourLeafClover : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fake Four Leaf Clover");
            Tooltip.SetDefault("Aww... it's fake!");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/FakeFourLeafClover");
            item.rare = 2;
            item.width = dims.Width;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 30);
            item.height = dims.Height;
        }
    }