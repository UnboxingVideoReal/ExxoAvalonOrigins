using Microsoft.Xna.Framework;
        public override void AI()
        {
			projectile.scale *= 0.985f;
			projectile.ai[0] += 1f;
			if (projectile.ai[0] == 4f)
			{
				for (int num257 = 0; num257 < 10; num257++)
				{
					int newDust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), 8, 8, 211, projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f, 100, default(Color), 1f);
					Main.dust[newDust].position = (Main.dust[newDust].position + projectile.Center) / 2f;
					Main.dust[newDust].noGravity = true;
					Main.dust[newDust].velocity *= 0.5f;
				}
			}
			if (Main.rand.Next(6) == 5)
			{
				Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), 8, 8, 211, projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f, 100, default(Color), 1f);
			}
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Wet, 120);
		}
		public override void Kill(int timeLeft)
        {
			Main.PlaySound(SoundID.NPCDeath9, projectile.position);
			for (int num237 = 0; num237 < 10; num237++)
			{
				int num239 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), 8, 8, 211, projectile.oldVelocity.X * 0.2f, projectile.oldVelocity.Y * 0.2f, 100, default(Color), 1f);
				Dust dust30 = Main.dust[num239];
				dust30.noGravity = false;
				dust30.scale = 1f;
			}
		}