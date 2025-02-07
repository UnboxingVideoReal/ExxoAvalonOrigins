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
	class SpikeCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spike Cannon");
			Tooltip.SetDefault("Uses spikes for ammo\n'You should be careful with this'");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SpikeCannon");
			item.damage = 50;
			item.autoReuse = true;
			item.useTurn = false;
			item.useAmmo = 147;
			item.shootSpeed = 14f;
			item.crit += 2;
			item.ranged = true;
			item.rare = ItemRarityID.LightRed;
			item.noMelee = true;
			item.width = dims.Width;
			item.knockBack = 8f;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<Projectiles.SpikeCannon>();
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 30;
			item.height = dims.Height;
            item.UseSound = SoundID.Item11;
        }
	}
}