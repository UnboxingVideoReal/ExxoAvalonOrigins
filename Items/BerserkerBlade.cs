﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items
{
    class BerserkerBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Berserker Blade");
            Tooltip.SetDefault("'Go berserk!'");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/BerserkerBlade");
            item.damage = 166;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.useTurn = true;
            item.scale = 1.2f;
            item.rare = ItemRarityID.Yellow;
            item.width = dims.Width;
            item.useTime = 10;
            item.knockBack = 5f;
            item.melee = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.value = Item.sellPrice(0, 12);
            item.useAnimation = 10;
            item.height = dims.Height;
            if (!Main.dedServ)
            {
                item.GetGlobalItem<ItemUseGlow>().glowTexture = mod.GetTexture("Items/BerserkerBlade_Glow");
            }
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = mod.GetTexture("Items/BerserkerBlade_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<BerserkerBar>(), 40);
            recipe.AddIngredient(ModContent.ItemType<VoraylzumKatana>());
            recipe.AddTile(ModContent.TileType<Tiles.XeradonAnvil>());
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<BerserkerBar>(), 40);
            recipe.AddIngredient(ModContent.ItemType<UnvolanditeGreatsword>());
            recipe.AddTile(ModContent.TileType<Tiles.XeradonAnvil>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}