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
	public class Rogue : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Rogue");
			Description.SetDefault("-5% ranged damage, 20% chance to not consume ammo");
		}

		public override void Update(Player player, ref int k)
		{
				player.rangedDamage -= 0.05f;
				player.ammoCost80 = true;
		}
	}
}