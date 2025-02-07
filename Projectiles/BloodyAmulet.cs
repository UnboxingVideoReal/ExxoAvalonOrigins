using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace ExxoAvalonOrigins.Projectiles
{
	public class BloodyAmulet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Amulet");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/BloodyAmulet");
			projectile.aiStyle = -1;
			projectile.width = dims.Width;
			projectile.height = dims.Height / Main.projFrames[projectile.type];
			projectile.damage = 0;
			projectile.tileCollide = false;
		}

        public override void AI()
        {
            if (projectile.active)
            {
                Main.dayTime = false;
                Main.time = 0.0;
                Main.bloodMoon = true;
                if (Main.netMode == NetmodeID.SinglePlayer)
                {
                    Main.NewText("The Blood Moon is rising...", 50, 255, 130, false);
                }
                else if (Main.netMode == NetmodeID.Server)
                {
                    NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon is rising..."), 255, 50f, 255f, 130f, 0);
                }
                projectile.active = false;
                return;
            }
        }
    }
}