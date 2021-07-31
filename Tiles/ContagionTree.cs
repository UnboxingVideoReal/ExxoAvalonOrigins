﻿using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Tiles
{
    class ContagionTree : ModTree
    {
        private Mod mod
        {
            get
            {
                return ModLoader.GetMod("ExxoAvalonOrigins");
            }
        }

        public override int DropWood()
        {
            return mod.ItemType("Coughwood");
        }

        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/ContagionTree");
        }

        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/ContagionTreeBranches");
        }

        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
        {
            frameWidth = 80;
            frameHeight = 80;
            yOffset += 2;
            //xOffsetLeft += 16;
            return mod.GetTexture("Tiles/ContagionTreeTop");
        }
    }
}