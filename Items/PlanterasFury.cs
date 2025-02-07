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
	class PlanterasFury : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plantera's Fury");
			Tooltip.SetDefault("60% chance to not consume ammo");
		}
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15f, 0f);
        }
        public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/PlanterasFury");
			item.damage = 35;
			item.autoReuse = true;
			item.useTurn = false;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 14f;
			item.crit += 2;
			item.ranged = true;
			item.rare = ItemRarityID.Yellow;
			item.noMelee = true;
			item.width = dims.Width;
			item.knockBack = 3f;
			item.useTime = 4;
			item.shoot = ProjectileID.Bullet;
			item.value = Item.sellPrice(0, 30, 0, 0);
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 4;
			item.height = dims.Height;
            item.UseSound = SoundID.Item41;
		}
	}
}