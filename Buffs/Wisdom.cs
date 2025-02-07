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
	public class Wisdom : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Wisdom");
			Description.SetDefault("-8% magic damage, +60 mana");
		}

		public override void Update(Player player, ref int k)
		{
				player.statManaMax2 += 60;
				player.magicDamage -= 0.08f;
		}
	}
}