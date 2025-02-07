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
	class Moonfury : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonfury");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/Moonfury");
			item.UseSound = SoundID.Item1;
			item.damage = 44;
			item.noUseGraphic = true;
			item.channel = true;
			item.scale = 1.1f;
			item.shootSpeed = 12f;
			item.noMelee = true;
			item.rare = ItemRarityID.Orange;
			item.width = dims.Width;
			item.useTime = 42;
			item.knockBack = 6.75f;
			item.shoot = ModContent.ProjectileType<Projectiles.Moonfury>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 54000;
			item.useAnimation = 42;
			item.height = dims.Height;
		}
	}
}