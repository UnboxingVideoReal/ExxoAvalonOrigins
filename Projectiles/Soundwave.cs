using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;

namespace ExxoAvalonOrigins.Projectiles
{
	public class Soundwave : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soundwave");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/Soundwave");
			projectile.width = 20;
			projectile.height = 28;
			projectile.scale = 1f;
			projectile.aiStyle = -1;
			projectile.timeLeft = 700;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.MaxUpdates = 2;
			projectile.magic = true;
		}
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            spriteBatch.End();
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, SamplerState.PointClamp, null, null);
            return true;
        }
        public override void PostDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            spriteBatch.End();
            spriteBatch.Begin();
        }
        public override void AI()
		{
            projectile.ai[0]++;
			if (projectile.type == ModContent.ProjectileType<Soundwave>())
			{
				projectile.scale = Math.Min(7f, 185.08197f * (float)Math.Pow(0.99111479520797729, projectile.timeLeft));
				projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
				var v = projectile.Center - new Vector2(projectile.width * projectile.scale / 2f, projectile.height * projectile.scale / 2f);
				var wH = new Vector2(projectile.width * projectile.scale, projectile.height * projectile.scale);
				var value2 = ExxoAvalonOrigins.NewRectVector2(v, wH);
				var npc = Main.npc;
				for (var num57 = 0; num57 < npc.Length; num57++)
				{
					var nPC = npc[num57];
					if (nPC.active && !nPC.dontTakeDamage && !nPC.friendly && nPC.life >= 1 && nPC.getRect().Intersects(value2))
					{
						if (projectile.ai[0] % 7 == 0) nPC.StrikeNPC(projectile.damage, projectile.knockBack, (nPC.Center.X < projectile.Center.X) ? -1 : 1, false, false);
					}
				}
			}
			projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}
		}
	}
}