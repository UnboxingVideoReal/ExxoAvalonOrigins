﻿using Microsoft.Xna.Framework;
    class ImperviousDoor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Impervious Door");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/ImperviousDoor");
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.ClosedImperviousDoor>();
            item.width = dims.Width;
            item.useTurn = true;
            item.useTime = 10;
            item.useStyle = 1;
            item.maxStack = 99;
            item.value = 200;
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }