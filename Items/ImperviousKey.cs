﻿using Microsoft.Xna.Framework;

namespace ExxoAvalonOrigins.Items
{
    public class ImperviousKey : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Impervious Key");
            Tooltip.SetDefault("Opens the Hellcastle doors");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/ImperviousKey");
            item.maxStack = 999;
            item.width = dims.Width;
            item.value = 0;
            item.height = dims.Height;
            item.rare = 9;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TempleKey, 10);
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
            recipe.AddIngredient(ModContent.ItemType<EarthStone>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}