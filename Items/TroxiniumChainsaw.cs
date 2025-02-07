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
	class TroxiniumChainsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Troxinium Chainsaw");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TroxiniumChainsaw");
			item.damage = 32;
			item.noUseGraphic = true;
			item.channel = true;
			item.axe = 20;
			item.shootSpeed = 40f;
			item.rare = ItemRarityID.Pink;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 6;
			item.knockBack = 4.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.TroxiniumChainsaw>();
			item.melee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 108000;
			item.useAnimation = 25;
			item.height = dims.Height;
		}
	}
}