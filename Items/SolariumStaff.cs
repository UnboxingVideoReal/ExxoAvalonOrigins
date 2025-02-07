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
	class SolariumStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solarium Staff");
            Item.staff[item.type] = true;
        }

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SapphireStaff);
			Item.staff[item.type] = true;
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/SolariumStaff");
			item.width = dims.Width;
			item.height = dims.Height;
			item.damage = 59;
			item.autoReuse = true;
			item.shootSpeed = 9f;
			item.mana = 19;
			item.rare = ItemRarityID.Cyan;
			item.knockBack = 6f;
			item.useTime = 19;
			item.useAnimation = 19;
			item.shoot = ModContent.ProjectileType<Projectiles.SolarBolt>();
			item.value = Item.sellPrice(0, 10, 0, 0);
		}
	}
}