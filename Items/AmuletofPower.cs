using Microsoft.Xna.Framework;
            player.magicDamage += 0.03f;
            player.meleeDamage += 0.03f;
            player.rangedDamage += 0.03f;
            player.minionDamage += 0.03f;
            player.thrownDamage += 0.03f;
            player.magicCrit += 3;
            player.meleeCrit += 3;
            player.rangedCrit += 3;
            player.thrownCrit += 3;
            player.statManaMax2 += 40;
            player.statLifeMax2 += 40;
        }
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<AmethystAmulet>());
            recipe.AddIngredient(ModContent.ItemType<TopazAmulet>());
            recipe.AddIngredient(ModContent.ItemType<SapphireAmulet>());
            recipe.AddIngredient(ModContent.ItemType<EmeraldAmulet>());
            recipe.AddIngredient(ModContent.ItemType<RubyAmulet>());
            recipe.AddIngredient(ModContent.ItemType<DiamondAmulet>());
            recipe.AddIngredient(ModContent.ItemType<TourmalineAmulet>());
            recipe.AddIngredient(ModContent.ItemType<PeridotAmulet>());
            recipe.AddIngredient(ModContent.ItemType<ZirconAmulet>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }