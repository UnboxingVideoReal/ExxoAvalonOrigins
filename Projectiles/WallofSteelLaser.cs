﻿using Microsoft.Xna.Framework;
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
    public class WallofSteelLaser : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall of Steel Laser");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/WallofSteelLaser");
            projectile.width = dims.Width * 4 / 20;
            projectile.height = dims.Height * 4 / 20 / Main.projFrames[projectile.type];
            projectile.aiStyle = -1;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.penetrate = 4;
            projectile.light = 0.8f;
            projectile.alpha = 0;
            projectile.scale = 1.2f;
            projectile.timeLeft = 1200;
            projectile.ranged = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }
        }
    }
}