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
	class HellWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell Wall");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/HellWall");
			item.autoReuse = true;
			item.consumable = true;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 7;
			item.createWall = ModContent.WallType<Walls.HellWall>();
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 999;
			item.useAnimation = 15;
			item.height = dims.Height;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddIngredient(ItemID.Hellstone);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }
}