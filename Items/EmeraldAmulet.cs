using Microsoft.Xna.Framework;
            player.rangedDamage += 0.05f;
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Emerald, 12);
            recipe.AddIngredient(ItemID.Chain);
            recipe.SetResult(this);
            recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();
        }
    }