using Microsoft.Xna.Framework;
			if (projectile.alpha > 0)
			{
				projectile.alpha -= 15;
			}
			if (projectile.alpha < 0)
			{
				projectile.alpha = 0;
			}
			for (int num168 = 0; num168 < 2; num168++)
			{
				int num171 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width, projectile.height, DustID.Enchanted_Pink, projectile.velocity.X * 0.1f, projectile.velocity.Y * 0.1f, 80, default(Color), 1.3f);
				Main.dust[num171].velocity *= 0.3f;
				Main.dust[num171].noGravity = true;
			}