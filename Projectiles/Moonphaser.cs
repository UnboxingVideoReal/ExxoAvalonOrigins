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
	public class Moonphaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonphaser");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/Moonphaser");
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
				Main.moonPhase++;
				if (Main.moonPhase >= 8)
				{
					Main.moonPhase = 0;
				}
				if (Main.netMode == NetmodeID.SinglePlayer)
				{
					if (Main.moonPhase == 0)
					{
						Main.NewText("Moon Phase is now Full.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 1)
					{
						Main.NewText("Moon Phase is now Last Gibbous.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 2)
					{
						Main.NewText("Moon Phase is now Last Quarter.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 3)
					{
						Main.NewText("Moon Phase is now Last Crescent.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 4)
					{
						Main.NewText("Moon Phase is now New.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 5)
					{
						Main.NewText("Moon Phase is now First Crescent.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 6)
					{
						Main.NewText("Moon Phase is now First Quarter.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
					if (Main.moonPhase == 7)
					{
						Main.NewText("Moon Phase is now First Gibbous.", 50, 255, 130, false);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							Main.NewText("The Blood Moon has risen...", 50, 255, 130, false);
						}
						projectile.active = false;
						return;
					}
				}
				else if (Main.netMode == NetmodeID.Server)
				{
					if (Main.moonPhase == 0)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now Full."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 1)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now Last Gibbous."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 2)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now Last Quarter."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 3)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now Last Crescent."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 4)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now New."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 5)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now First Crescent."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 6)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now First Quarter."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
					}
					if (Main.moonPhase == 7)
					{
						NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("Moon Phase is now First Gibbous."), 255, 50f, 255f, 130f, 0);
						if (Main.rand.Next(14) == 0 && !Main.dayTime)
						{
							Main.bloodMoon = true;
							NetMessage.SendData(MessageID.ChatText, -1, -1, NetworkText.FromLiteral("The Blood Moon has risen..."), 255, 50f, 255f, 130f, 0);
						}
						projectile.active = false;
						return;
					}
				}
			}
		}
	}
}