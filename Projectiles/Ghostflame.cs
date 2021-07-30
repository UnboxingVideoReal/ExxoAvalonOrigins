﻿using Microsoft.Xna.Framework;
    public class Ghostflame : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghostflame");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/Ghostflame");
            projectile.width = dims.Width;
            projectile.height = dims.Height / Main.projFrames[projectile.type];
            projectile.aiStyle = -1;
            projectile.tileCollide = false;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.timeLeft = 100;
            projectile.light = 1f;
            projectile.penetrate = -1;
            projectile.magic = true;
            projectile.ignoreWater = true;
        }
        {
            //if (Main.rand.Next(2) == 0) target.AddBuff(ModContent.BuffType<Buffs.DarkInferno>(), 240);
        }
            int num890 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 180, 0f, 0f, 0, default(Color), 1f);
            Main.dust[num890].velocity *= 0.1f;
            Main.dust[num890].scale = 1.3f;
            Main.dust[num890].noGravity = true;
            if (projectile.ai[1] >= 20f)
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.2f;
            }
            projectile.rotation += 0.3f * projectile.direction;
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }