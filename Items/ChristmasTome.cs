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
	class ChristmasTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Christmas Tome");
			Tooltip.SetDefault("Tome\n+3% critical strike chance");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ChristmasTome");
			item.rare = ItemRarityID.LightPurple;
			item.width = dims.Width;
			item.value = 15000;
			item.height = dims.Height;
            item.GetGlobalItem<ExxoAvalonOriginsGlobalItemInstance>().tome = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magicCrit += 3;
            player.meleeCrit += 3;
            player.rangedCrit += 3;
            player.thrownCrit += 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MysticalClaw>(), 3);
            recipe.AddIngredient(ModContent.ItemType<MysteriousPage>(), 2);
            recipe.AddIngredient(ModContent.ItemType<Sandstone>(), 5);
            recipe.AddIngredient(ModContent.ItemType<DewOrb>());
            recipe.AddIngredient(ModContent.ItemType<MysticalTomePage>(), 2);
            recipe.AddTile(ModContent.TileType<Tiles.TomeForge>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}