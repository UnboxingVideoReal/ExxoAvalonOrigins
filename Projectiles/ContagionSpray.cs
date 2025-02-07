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
	public class ContagionSpray : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Contagion Spray");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/ContagionSpray");
			projectile.width = dims.Width * 6 / 16;
			projectile.height = dims.Height * 6 / 16 / Main.projFrames[projectile.type];
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.alpha = 255;
			projectile.penetrate = -1;
			projectile.MaxUpdates = 2;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
		}

        public override void AI()
        {
            var num500 = 110;
            var num501 = 0;
            num500 = 237;
            num501 = 6;
            if (projectile.owner == Main.myPlayer)
            {
                WorldGen.Convert((int)(projectile.position.X + projectile.width / 2) / 16, (int)(projectile.position.Y + projectile.height / 2) / 16, num501, 2);
            }
            if (projectile.timeLeft > 133)
            {
                projectile.timeLeft = 133;
            }
            if (projectile.ai[0] > 7f)
            {
                var num502 = 1f;
                if (projectile.ai[0] == 8f)
                {
                    num502 = 0.2f;
                }
                else if (projectile.ai[0] == 9f)
                {
                    num502 = 0.4f;
                }
                else if (projectile.ai[0] == 10f)
                {
                    num502 = 0.6f;
                }
                else if (projectile.ai[0] == 11f)
                {
                    num502 = 0.8f;
                }
                projectile.ai[0] += 1f;
                for (var num503 = 0; num503 < 1; num503++)
                {
                    var num504 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, num500, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1f);
                    Main.dust[num504].noGravity = true;
                    Main.dust[num504].scale *= 1.75f;
                    var dust57 = Main.dust[num504];
                    dust57.velocity.X = dust57.velocity.X * 2f;
                    var dust58 = Main.dust[num504];
                    dust58.velocity.Y = dust58.velocity.Y * 2f;
                    Main.dust[num504].scale *= num502;
                }
            }
            else
            {
                projectile.ai[0] += 1f;
            }
            projectile.rotation += 0.3f * projectile.direction;
        }
    }
}