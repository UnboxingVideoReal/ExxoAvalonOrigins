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
	public class GastrominiSummon : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gastromini");
            Main.projPet[projectile.type] = true;
        }

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Projectiles/GastrominiSummon");
			projectile.netImportant = true;
			projectile.width = dims.Width * 22 / 132;
			projectile.height = dims.Height * 22 / 132 / Main.projFrames[projectile.type];
			projectile.aiStyle = -1;
			projectile.penetrate = -1;
			projectile.timeLeft *= 5;
			projectile.minion = true;
			projectile.minionSlots = 1f;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.friendly = true;
			Main.projFrames[projectile.type] = 5;
			Main.projPet[projectile.type] = true;
		}

		public override void AI()
		{
			if (projectile.type == ModContent.ProjectileType<GastrominiSummon>())
			{
				if (Main.player[projectile.owner].dead)
				{
					Main.player[projectile.owner].GetModPlayer<ExxoAvalonOriginsModPlayer>().gastroMinion = false;
				}
				if (Main.player[projectile.owner].GetModPlayer<ExxoAvalonOriginsModPlayer>().gastroMinion)
				{
					projectile.timeLeft = 2;
				}
			}
			var num820 = 0.05f;
			for (var num821 = 0; num821 < 1000; num821++)
			{
				if (num821 != projectile.whoAmI && Main.projectile[num821].active && Main.projectile[num821].owner == projectile.owner && (Main.projectile[num821].type == 387 || Main.projectile[num821].type == 388 || Main.projectile[num821].type == 485 || Main.projectile[num821].type == 498) && Math.Abs(projectile.position.X - Main.projectile[num821].position.X) + Math.Abs(projectile.position.Y - Main.projectile[num821].position.Y) < projectile.width)
				{
					if (projectile.position.X < Main.projectile[num821].position.X)
					{
						projectile.velocity.X = projectile.velocity.X - num820;
					}
					else
					{
						projectile.velocity.X = projectile.velocity.X + num820;
					}
					if (projectile.position.Y < Main.projectile[num821].position.Y)
					{
						projectile.velocity.Y = projectile.velocity.Y - num820;
					}
					else
					{
						projectile.velocity.Y = projectile.velocity.Y + num820;
					}
				}
			}
			var vector57 = projectile.position;
			var num822 = 400f;
			var flag32 = false;
			if (projectile.ai[0] != 1f)
			{
				projectile.tileCollide = true;
			}
			for (var num823 = 0; num823 < 200; num823++)
			{
				var nPC5 = Main.npc[num823];
				if (nPC5.active && !nPC5.dontTakeDamage && !nPC5.friendly && nPC5.lifeMax > 5)
				{
					var num824 = Vector2.Distance(nPC5.Center, projectile.Center);
					if (((Vector2.Distance(projectile.Center, vector57) > num824 && num824 < num822) || !flag32) && Collision.CanHitLine(projectile.position, projectile.width, projectile.height, nPC5.position, nPC5.width, nPC5.height))
					{
						num822 = num824;
						vector57 = nPC5.Center;
						flag32 = true;
					}
				}
			}
			var num825 = 500;
			if (flag32)
			{
				num825 = 1000;
			}
			var player2 = Main.player[projectile.owner];
			if (Vector2.Distance(player2.Center, projectile.Center) > num825)
			{
				projectile.ai[0] = 1f;
				projectile.tileCollide = false;
				projectile.netUpdate = true;
			}
			if (flag32 && projectile.ai[0] == 0f)
			{
				var vector58 = vector57 - projectile.Center;
				var num826 = vector58.Length();
				vector58.Normalize();
				if (num826 > 200f)
				{
					var scaleFactor5 = 6f;
					vector58 *= scaleFactor5;
					projectile.velocity = (projectile.velocity * 40f + vector58) / 41f;
				}
				else
				{
					var num827 = 4f;
					vector58 *= -num827;
					projectile.velocity = (projectile.velocity * 40f + vector58) / 41f;
				}
			}
			else
			{
				var num828 = 6f;
				if (projectile.ai[0] == 1f)
				{
					num828 = 15f;
				}
				var value22 = projectile.Center;
				var vector59 = player2.Center - value22 + new Vector2(0f, -60f);
				var num829 = vector59.Length();
				if (num829 > 200f && num828 < 8f)
				{
					num828 = 8f;
				}
				if (num829 < 150f && projectile.ai[0] == 1f && !Collision.SolidCollision(projectile.position, projectile.width, projectile.height))
				{
					projectile.ai[0] = 0f;
					projectile.netUpdate = true;
				}
				if (num829 > 2000f)
				{
					projectile.position.X = Main.player[projectile.owner].Center.X - projectile.width / 2;
					projectile.position.Y = Main.player[projectile.owner].Center.Y - projectile.height / 2;
					projectile.netUpdate = true;
				}
				if (num829 > 70f)
				{
					vector59.Normalize();
					vector59 *= num828;
					projectile.velocity = (projectile.velocity * 40f + vector59) / 41f;
				}
				else if (projectile.velocity.X == 0f && projectile.velocity.Y == 0f)
				{
					projectile.velocity.X = -0.15f;
					projectile.velocity.Y = -0.05f;
				}
			}
			projectile.frameCounter++;
			if (projectile.frameCounter > 3)
			{
				projectile.frame++;
				projectile.frameCounter = 0;
			}
			if (projectile.frame > 2)
			{
				projectile.frame = 0;
			}
			if (projectile.ai[1] > 0f)
			{
				projectile.ai[1] += Main.rand.Next(1, 4);
			}
			if (projectile.ai[1] > 90f && projectile.type == ModContent.ProjectileType<GastrominiSummon>())
			{
				projectile.ai[1] = 0f;
				projectile.netUpdate = true;
			}
			if (projectile.ai[0] == 0f)
			{
				if (projectile.type == ModContent.ProjectileType<GastrominiSummon>())
				{
					var scaleFactor7 = 8f;
					int num832 = ProjectileID.MiniRetinaLaser;
					if (flag32 && projectile.ai[1] == 0f)
					{
						projectile.ai[1] += 1f;
						if (Main.myPlayer == projectile.owner && Collision.CanHitLine(projectile.position, projectile.width, projectile.height, vector57, 0, 0))
						{
							var value24 = vector57 - projectile.Center;
							value24.Normalize();
							value24 *= scaleFactor7;
							var num833 = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, value24.X, value24.Y, num832, (int)(projectile.damage * 0.8f), 0f, Main.myPlayer, 0f, 0f);
							Main.projectile[num833].timeLeft = 300;
							projectile.netUpdate = true;
						}
					}
				}
			}
		}
	}
}