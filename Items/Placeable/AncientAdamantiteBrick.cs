using Microsoft.Xna.Framework;
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.AdamantiteBeam);
            r.AddTile(ModContent.TileType<Tiles.AncientWorkbench>());
            r.SetResult(this);
            r.AddRecipe();

            r = new ModRecipe(mod);
            r.AddIngredient(this);
            r.AddTile(ModContent.TileType<Tiles.AncientWorkbench>());
            r.SetResult(ItemID.AdamantiteBeam);
            r.AddRecipe();
        }
    }