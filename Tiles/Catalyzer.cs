using Microsoft.Xna.Framework;

namespace ExxoAvalonOrigins.Tiles
            animationFrameHeight = 38;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.LavaDeath = false;
        {
            frameCounter++;
            if (frameCounter > 12)
            {
                frameCounter = 0;
                frame++;
                if (frame >= 12) frame = 0;
            }
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)