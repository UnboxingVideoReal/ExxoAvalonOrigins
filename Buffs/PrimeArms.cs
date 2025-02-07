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
	public class PrimeArms : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Prime Arms");
			Description.SetDefault("The arms will fight for you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int k)
		{
				if (player.ownedProjectileCounts[474] > 0 || player.ownedProjectileCounts[475] > 0 || player.ownedProjectileCounts[476] > 0 || player.ownedProjectileCounts[477] > 0)
				{
					player.GetModPlayer<ExxoAvalonOriginsModPlayer>().primeMinion = true;
				}
				if (!player.GetModPlayer<ExxoAvalonOriginsModPlayer>().primeMinion)
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