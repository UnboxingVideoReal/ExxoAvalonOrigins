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
	public class CrimsonSeed : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Seed");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/CrimsonSeed");
			projectile.width = dims.Width * 8 / 10;
			projectile.height = dims.Height * 8 / 10 / Main.projFrames[projectile.type];
			projectile.aiStyle = -1;
			projectile.friendly = true;
		}
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Dig, (int)projectile.position.X, (int)projectile.position.Y, 1);
            return true;
        }
        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 15f)
            {
                projectile.ai[0] = 15f;
                projectile.velocity.Y = projectile.velocity.Y + 0.1f;
            }
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }
        }
    }
}