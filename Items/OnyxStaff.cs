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
	class OnyxStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Onyx Staff");
            Item.staff[item.type] = true;
        }

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.SapphireStaff);
			Item.staff[item.type] = true;
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/OnyxStaff");
			item.width = dims.Width;
			item.height = dims.Height;
			item.damage = 116;
			item.autoReuse = true;
			item.shootSpeed = 9.5f;
			item.mana = 20;
			item.rare = ItemRarityID.Cyan;
			item.useTime = 19;
			item.useAnimation = 19;
			item.knockBack = 25.5f;
			item.shoot = ModContent.ProjectileType<Projectiles.OnyxBolt>();
			item.value = Item.buyPrice(0, 35, 0, 0);
            item.UseSound = SoundID.Item43;
        }
	}
}