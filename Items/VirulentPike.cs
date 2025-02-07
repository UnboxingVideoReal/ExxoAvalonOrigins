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
	class VirulentPike : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Virulent Pike");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VirulentPike");
			item.damage = 18;
			item.UseSound = SoundID.Item1;
			item.noUseGraphic = true;
			item.scale = 1f;
			item.shootSpeed = 3.6f;
			item.rare = ItemRarityID.Blue;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 24;
			item.useAnimation = 24;
			item.knockBack = 2.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.VirulentPike>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = Item.sellPrice(0, 0, 36, 0);
			item.height = dims.Height;
		}
	}
}