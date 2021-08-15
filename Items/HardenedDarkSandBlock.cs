﻿using Microsoft.Xna.Framework;
    class HardenedDarkSandBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hardened Dark Sand Block");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/HardenedDarkSandBlock");
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.HardenedDarkSand>();
            item.width = dims.Width;
            item.useTurn = true;
            item.useTime = 10;
            item.useStyle = 1;
            item.maxStack = 999;
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }