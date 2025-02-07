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
	class VertexofExcalibur : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vertex of Excalibur");
			Tooltip.SetDefault("Deals more damage to foes inflicted by a debuff\n'The unification of dark and light'");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VertexofExcalibur");
			item.UseSound = SoundID.Item1;
			item.damage = 105;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.2f;
			item.rare = ItemRarityID.Yellow;
			item.width = dims.Width;
			item.useTime = 18;
			item.knockBack = 5f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 9, 63, 0);
			item.useAnimation = 18;
			item.height = dims.Height;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				int num313 = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Enchanted_Pink);
				Main.dust[num313].noGravity = true;
				Main.dust[num313].fadeIn = 1.25f;
				Main.dust[num313].velocity *= 0.25f;
			}
		}
		public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
			bool hasDebuff = false;
			for (int i = 0; i < target.buffType.Length; i++)
			{
				if (Main.debuff[target.buffType[i]])
				{
					hasDebuff = true;
					break;
				}
			}
			if (hasDebuff) damage *= 2;
		}
	}
}