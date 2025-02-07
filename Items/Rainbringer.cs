using Microsoft.Xna.Framework;
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
	class Rainbringer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rainbringer");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Rainbringer");
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<Projectiles.Rainbringer>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 2, 70, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
		}

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainCloud, 50);
			recipe.AddRecipeGroup(RecipeGroup.recipeGroupIDs["ExxoAvalonOrigins:CopperBar"], 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(item.type);
			recipe.AddRecipe();
		}
    }
}