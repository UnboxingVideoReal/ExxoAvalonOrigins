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
	class EnergyRevolver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Energy Revolver");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/EnergyRevolver");
			item.magic = true;
			item.damage = 57;
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.mana = 6;
			item.noMelee = true;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.knockBack = 2f;
			item.useTime = 6;
			item.shoot = ProjectileID.GreenLaser;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = Item.sellPrice(0, 2, 60, 0);
			item.useAnimation = 6;
			item.height = dims.Height;
            item.UseSound = SoundID.Item12;
        }
	}
}