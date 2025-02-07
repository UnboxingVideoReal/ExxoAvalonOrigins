using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;

namespace ExxoAvalonOrigins.Buffs
{
	public class Shockwave : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Shockwave");
			Description.SetDefault("On-screen enemies take damage when you land");
		}

		public override void Update(Player player, ref int k)
		{
				player.GetModPlayer<ExxoAvalonOriginsModPlayer>().shockWave = true;
				var screenWidth = Main.screenWidth;
				var screenHeight = Main.screenHeight;
				var num3 = (int)Main.screenPosition.X;
				var num4 = (int)Main.screenPosition.Y;
				if (player.GetModPlayer<ExxoAvalonOriginsModPlayer>().fallStart_old == -1)
				{
					player.GetModPlayer<ExxoAvalonOriginsModPlayer>().fallStart_old = player.fallStart;
				}
				var num5 = 0;
				if (player.velocity.Y == 0f)
				{
					num5 = (int)(((int)(player.position.Y / 16f) - player.GetModPlayer<ExxoAvalonOriginsModPlayer>().fallStart_old) * player.gravDir);
				}
				var vector = player.position + new Vector2(player.width, player.height) / 2f;
				if (num5 > 3)
				{
					for (var num6 = 0; num6 < Main.npc.Length; num6++)
					{
						var nPC2 = Main.npc[num6];
						if (nPC2.active && !nPC2.dontTakeDamage && !nPC2.friendly && nPC2.life >= 1)
						{
							var vector2 = new Vector2(nPC2.position.X + nPC2.width * 0.5f, nPC2.position.Y + nPC2.height * 0.5f);
							var hitDirection = -1;
							if (vector2.X > vector.X)
							{
								hitDirection = 1;
							}
							if (nPC2.position.X >= num3 && nPC2.position.X <= num3 + screenWidth && nPC2.position.Y >= num4 && nPC2.position.Y <= num4 + screenHeight)
							{
								nPC2.StrikeNPC((player.GetModPlayer<ExxoAvalonOriginsModPlayer>().earthInsig ? 3 : 2) * num5, 5f, hitDirection, false, false);
							}
						}
					}
				}
				player.GetModPlayer<ExxoAvalonOriginsModPlayer>().fallStart_old = player.fallStart;
		}
	}
}