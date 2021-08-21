using Microsoft.Xna.Framework;

namespace ExxoAvalonOrigins.Items
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
        {
            Texture2D texture = ModContent.GetTexture("ExxoAvalonOrigins/Items/RosebudGlow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }