using Microsoft.Xna.Framework;

namespace ExxoAvalonOrigins.Items
            item.noMelee = true;
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10f, 0f);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,
            float num79 = speedY + (float)Main.rand.Next(-50, 51) * 0.05f;
            if (Main.rand.Next(3) == 0)
            {
                num78 *= 1f + (float)Main.rand.Next(-40, 41) * 0.02f;
                num79 *= 1f + (float)Main.rand.Next(-40, 41) * 0.02f;
            }
            Projectile.NewProjectile(position.X, position.Y, num78, num79, ModContent.ProjectileType<Projectiles.Blahcket>(), damage, knockBack, player.whoAmI, 0f, 0f);
        {
            Vector2 vector = new Vector2(player.position.X + (float)player.width * 0.5f, player.position.Y + (float)player.height * 0.5f);
            float num70 = (float)Main.mouseX + Main.screenPosition.X - vector.X;
            float num71 = (float)Main.mouseY + Main.screenPosition.Y - vector.Y;
            if (player.gravDir == -1f)
            {
                num71 = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY - vector.Y;
            }
            float num72 = (float)Math.Sqrt((double)(num70 * num70 + num71 * num71));
            float num73 = num72;
            num72 = player.inventory[player.selectedItem].shootSpeed / num72;
            if (player.inventory[player.selectedItem].type == item.type)
            {
                num70 += (float)Main.rand.Next(-50, 51) * 0.03f / num72;
                num71 += (float)Main.rand.Next(-50, 51) * 0.03f / num72;
            }
            num70 *= num72;
            num71 *= num72;
            player.itemRotation = (float)Math.Atan2((double)(num71 * (float)player.direction), (double)(num70 * (float)player.direction));
        }
        {
            if (Main.rand.Next(4) < 2) return false;
            return base.ConsumeAmmo(player);
        }
    }