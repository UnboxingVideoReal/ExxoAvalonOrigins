﻿using Microsoft.Xna.Framework;
    class HerbologyBench : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Herbology Bench");
            Tooltip.SetDefault("Used for herb-related exchange");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/HerbologyBench");
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.HerbologyBench>();
            item.rare = 2;
            item.width = dims.Width;
            item.useTurn = true;
            item.useTime = 10;
            item.useStyle = 1;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 0, 20);
            item.useAnimation = 15;
            item.height = dims.Height;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddIngredient(ItemID.Wood, 45);
            recipe.AddIngredient(ItemID.GrassSeeds, 20);
            recipe.AddIngredient(ItemID.Daybloom, 15);
            recipe.AddRecipeGroup("ExxoAvalonOrigins:Herbs");
            recipe.AddRecipeGroup(RecipeGroupID.Wood);
            recipe.AddRecipeGroup(RecipeGroupID.IronBar);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }