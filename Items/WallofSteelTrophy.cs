﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items
{
    class WallofSteelTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall of Steel Trophy");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/WallofSteelTrophy");
            item.autoReuse = true;
            item.useTurn = true;
            item.maxStack = 99;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.BossTrophy>();
            item.placeStyle = 6;
            item.rare = 1;
            item.width = dims.Width;
            item.useTime = 10;
            item.useStyle = 1;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }
}