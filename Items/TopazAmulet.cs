using Microsoft.Xna.Framework;
            player.meleeDamage += 0.05f;
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 12);
            recipe.AddIngredient(ItemID.Chain);
            recipe.SetResult(this);
            recipe.AddTile(TileID.Anvils);
            recipe.AddRecipe();
        }
    }