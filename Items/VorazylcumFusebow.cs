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
	class VorazylcumFusebow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vorazylcum Fusebow");
			Tooltip.SetDefault("Fires a beam of energy");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VorazylcumFusebow");
			item.damage = 80;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 15f;
			item.ranged = true;
			item.rare = ItemRarityID.Cyan;
			item.noMelee = true;
			item.width = dims.Width;
			item.knockBack = 5f;
			item.useTime = 15;
			item.shoot = ModContent.ProjectileType<Projectiles.ArrowBeam>();
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = Item.sellPrice(0, 20, 0, 0);
			item.useAnimation = 15;
			item.height = dims.Height;
            item.UseSound = SoundID.Item5;
        }
	}
}