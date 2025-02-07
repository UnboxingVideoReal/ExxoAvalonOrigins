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
	public class Hungry : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hungry");
			Description.SetDefault("The hungry will fight for you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int k)
		{
				if (player.ownedProjectileCounts[485] > 0)
				{
					player.GetModPlayer<ExxoAvalonOriginsModPlayer>().hungryMinion = true;
				}
				if (!player.GetModPlayer<ExxoAvalonOriginsModPlayer>().hungryMinion)
				{
					player.DelBuff(k);
					k--;
				}
				else
				{
					player.buffTime[k] = 18000;
				}
		}
	}
}