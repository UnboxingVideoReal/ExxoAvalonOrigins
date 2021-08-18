using Microsoft.Xna.Framework;
        {
            if (meteorCooldown <= 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    int rand = Main.rand.Next(3);
                    Vector2 origin = new Vector2(projectile.Center.X, Main.player[projectile.owner].Center.Y) + new Vector2(Main.rand.NextFloat(-250f, 251f), -600f);
                    Vector2 rotation = target.Center - origin;
                    if (rotation.Y < 0f)
                        rotation.Y *= -1f;
                    if (rotation.Y < 6f)
                        rotation.Y = 6f;
                    rotation.Normalize();
                    rotation *= new Vector2(6f, 6f).Length();
                    Vector2 velocity = new Vector2(rotation.X, rotation.Y + Main.rand.Next(-40, 41) * 0.02f);
                    int meteor = Projectile.NewProjectile(origin, velocity, ProjectileID.Meteor1 + rand, projectile.damage, projectile.knockBack, projectile.owner, 0f, 0.5f + (float)Main.rand.NextDouble() * 0.3f);
                }
                meteorCooldown = 120;
            }
        }