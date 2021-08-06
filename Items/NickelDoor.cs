﻿using Microsoft.Xna.Framework;
    class NickelDoor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Door");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/NickelDoor");
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.ClosedNickelDoor>();
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