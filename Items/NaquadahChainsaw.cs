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
	class NaquadahChainsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Naquadah Chainsaw");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/NaquadahChainsaw");
			item.damage = 29;
			item.noUseGraphic = true;
			item.channel = true;
			item.axe = 18;
			item.shootSpeed = 40f;
			item.rare = ItemRarityID.LightRed;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 6;
			item.knockBack = 4.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.NaquadahChainsaw>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 108000;
			item.useAnimation = 25;
			item.height = dims.Height;
            item.UseSound = SoundID.Item23;
        }
	}
}