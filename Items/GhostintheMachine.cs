﻿using Microsoft.Xna.Framework;
    class GhostintheMachine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghost in the Machine");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/GhostintheMachine");
            item.rare = 7;
            item.width = dims.Width;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.height = dims.Height;
        }
    }