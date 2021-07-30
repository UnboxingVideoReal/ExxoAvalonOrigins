﻿using Microsoft.Xna.Framework;
    class EctoplasmicBeacon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ectoplasmic Beacon");
            Tooltip.SetDefault("Summons Phantasm\nMust be used in the Hellcastle");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/EctoplasmicBeacon");
            item.consumable = true;
            item.width = dims.Width;
            item.useTime = 45;
            item.useStyle = 4;
            item.value = 0;
            item.maxStack = 20;
            item.useAnimation = 45;
            item.height = dims.Height;
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddIngredient(ModContent.ItemType<SolariumStar>(), 8);
            recipe.AddTile(ModContent.TileType<Tiles.LibraryAltar>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }