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
	class AeonsEternity : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aeon's Eternity");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/AeonsEternity");
			item.damage = 36;
			item.scale = 1.1f;
			item.melee = true;
			item.autoReuse = true;
			item.useTurn = true;
			item.rare = 5;
			item.width = dims.Width;
			item.height = dims.Height;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.AeonBeam2>();
			item.shootSpeed = 11f;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(0, 1, 0, 0);
		}
	}
}