using Microsoft.Xna.Framework;
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ModContent.ItemType<ChunkstoneBlock>());
            r.AddIngredient(ItemID.StoneBlock);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();

            r = new ModRecipe(mod);
            r.AddIngredient(ModContent.ItemType<ChunkstoneBrickWall>(), 4);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }