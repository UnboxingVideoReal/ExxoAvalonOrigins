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
	class PurplePhasecleaver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Phasecleaver");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/PurplePhasecleaver");
			item.damage = 80;
			item.autoReuse = true;
			item.scale = 1.2f;
			item.useTurn = true;
			item.rare = ItemRarityID.Lime;
			item.width = dims.Width;
			item.useTime = 20;
			item.knockBack = 5.25f;
			item.melee = true;
			item.value = 70000;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 20;
			item.height = dims.Height;
            item.UseSound = SoundID.Item15;
        }
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			Lighting.AddLight((int)((player.itemLocation.X + 6f + player.velocity.X) / 16f), (int)((player.itemLocation.Y - 14f) / 16f), 0.4f, 0.05f, 0.5f);
		}
	}
}