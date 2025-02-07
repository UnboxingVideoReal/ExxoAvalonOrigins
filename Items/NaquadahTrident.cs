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
	class NaquadahTrident : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Naquadah Trident");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NaquadahTrident");
			item.UseSound = SoundID.Item1;
			item.damage = 35;
			item.noUseGraphic = true;
			item.scale = 1.1f;
			item.shootSpeed = 5f;
			item.rare = ItemRarityID.LightRed;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 26;
			item.knockBack = 5.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.NaquadahTrident>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 105000;
			item.useAnimation = 26;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}