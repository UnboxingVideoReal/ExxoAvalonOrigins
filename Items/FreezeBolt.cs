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
	class FreezeBolt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Freeze Bolt");
			Tooltip.SetDefault("Casts a fast-moving bolt of ice");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/FreezeBolt");
			item.magic = true;
			item.damage = 43;
			item.autoReuse = true;
			item.useTurn = true;
			item.shootSpeed = 7f;
			item.mana = 11;
			item.rare = ItemRarityID.Pink;
			item.noMelee = true;
			item.width = dims.Width;
			item.useTime = 17;
			item.knockBack = 5f;
			item.shoot = ModContent.ProjectileType<Projectiles.FreezeBolt>();
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.value = 50000;
			item.useAnimation = 17;
			item.height = dims.Height;
            item.UseSound = SoundID.Item21;
        }
	}
}