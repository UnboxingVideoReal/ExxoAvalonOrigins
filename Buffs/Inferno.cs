using Microsoft.Xna.Framework;

                if (N2.getRect().Intersects(npc.getRect())) N2.AddBuff(ModContent.BuffType<Inferno>(), 540);
            if (Main.rand.Next(5) == 0)
            {
                int num10 = Dust.NewDust(npc.position, npc.width, npc.height, 6, 0f, 0f, 0, default(Color), 1.8f);
                Main.dust[num10].noGravity = true;
            }
    }