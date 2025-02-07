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
	class ExcaliburNet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Exalibur Net");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ExcaliburNet");
			item.damage = 43;
			item.autoReuse = true;
			item.useTurn = true;
			item.rare = ItemRarityID.LightRed;
			item.width = dims.Width;
			item.knockBack = 4.2f;
			item.useTime = 23;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.useAnimation = 23;
			item.height = dims.Height;
            item.UseSound = SoundID.Item1;
        }
	}
}