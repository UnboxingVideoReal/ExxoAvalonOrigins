﻿using Microsoft.Xna.Framework;
    class TropicalWood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tropical Wood");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/TropicalWood");
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.TropicalWood>();
            item.width = dims.Width;
            item.useTime = 10;
            item.useTurn = true;
            item.useStyle = 1;
            item.maxStack = 999;
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }