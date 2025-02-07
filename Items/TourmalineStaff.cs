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
	class TourmalineStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tourmaline Staff");
            Item.staff[item.type] = true;
        }

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SapphireStaff);
			Item.staff[item.type] = true;
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TourmalineStaff");
			item.width = dims.Width;
			item.height = dims.Height;
			item.damage = 28;
			item.autoReuse = true;
			item.shootSpeed = 7.5f;
			item.mana = 9;
			item.rare = ItemRarityID.Blue;
			item.useTime = 28;
			item.useAnimation = 28;
			item.knockBack = 4.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.TourmalineBolt>();
			item.value = Item.buyPrice(0, 3, 50, 0);	
            item.UseSound = SoundID.Item43;
        }
	}
}