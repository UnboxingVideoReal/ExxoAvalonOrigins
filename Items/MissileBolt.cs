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
	class MissileBolt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Missile Bolt");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MissileBolt");
			item.shootSpeed = -1f;
			item.damage = 50;
			item.ammo = AmmoID.StyngerBolt;
			item.ranged = true;
			item.consumable = true;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.knockBack = 3f;
			item.shoot = ModContent.ProjectileType<Projectiles.MissileBolt>();
			item.maxStack = 2000;
			item.value = 150;
			item.height = dims.Height;
		}
	}
}