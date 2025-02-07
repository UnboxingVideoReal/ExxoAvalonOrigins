using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Projectiles
{
	public class BerserkerCrystal : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Berserker Crystal");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/BerserkerCrystal");
			projectile.width = dims.Width;
			projectile.height = dims.Height / Main.projFrames[projectile.type];
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.light = 0.5f;
			projectile.alpha = 50;
			projectile.scale = 1.2f;
			projectile.timeLeft = 600;
			projectile.ranged = true;
			projectile.tileCollide = false;
		}

		public override void AI()
		{
			projectile.light = projectile.scale * 0.5f;
			projectile.rotation += projectile.velocity.X * 0.2f;
			projectile.ai[1] += 1f;
			if (projectile.type == ProjectileID.CrystalStorm)
			{
				if (Main.rand.Next(4) == 0)
				{
					var num353 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, DustID.PurpleCrystalShard, 0f, 0f, 0, default(Color), 1f);
					Main.dust[num353].noGravity = true;
					Main.dust[num353].velocity *= 0.5f;
					Main.dust[num353].scale *= 0.9f;
				}
				projectile.velocity *= 0.985f;
				if (projectile.ai[1] > 130f)
				{
					projectile.scale -= 0.05f;
					if (projectile.scale <= 0.2)
					{
						projectile.scale = 0.2f;
						projectile.Kill();
					}
				}
			}
			else
			{
				projectile.velocity *= 0.96f;
				if (projectile.ai[1] > 15f)
				{
					projectile.scale -= 0.05f;
					if (projectile.scale <= 0.2)
					{
						projectile.scale = 0.2f;
						projectile.Kill();
					}
				}
			}
		}
	}
}