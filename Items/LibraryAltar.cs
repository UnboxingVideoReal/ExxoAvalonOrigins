﻿using Microsoft.Xna.Framework;
    class LibraryAltar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Library Altar");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/LibraryAltar");
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.LibraryAltar>();
            item.rare = 1;
            item.width = dims.Width;
            item.useTime = 10;
            item.useTurn = true;
            item.useStyle = 1;
            item.maxStack = 999;
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }