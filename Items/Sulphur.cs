﻿using Microsoft.Xna.Framework;
    class Sulphur : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sulphur");
            Tooltip.SetDefault("Used to convert items at the Catalyzer");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/Sulphur");
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.SulphurOre>();
            item.rare = 1;
            item.width = dims.Width;
            item.useTime = 10;
            item.useTurn = true;
            item.useStyle = 1;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }