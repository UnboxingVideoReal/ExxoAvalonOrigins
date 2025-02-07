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
	public class Gastropod : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Gastropod");
			Description.SetDefault("The gastropod will fight for you");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int k)
		{
            player.buffTime[k] = 18000;
            player.GetModPlayer<ExxoAvalonOriginsModPlayer>().gastroMinion = true;
            var petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.GastrominiSummon>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, ModContent.ProjectileType<Projectiles.GastrominiSummon>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
	}
}