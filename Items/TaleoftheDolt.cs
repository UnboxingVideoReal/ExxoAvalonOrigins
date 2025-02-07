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
	class TaleoftheDolt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tale of the Dolt");
			Tooltip.SetDefault("Tome\n+15% melee damage\n+20 HP, +20 mana");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TaleoftheDolt");
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.value = 15000;
			item.height = dims.Height;
            item.GetGlobalItem<ExxoAvalonOriginsGlobalItemInstance>().tome = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.15f;
            player.statLifeMax2 += 20;
            player.statManaMax2 += 20;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<FlankersTome>());
            recipe.AddIngredient(ModContent.ItemType<MistyPeachBlossoms>());
            recipe.AddTile(ModContent.TileType<Tiles.TomeForge>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}