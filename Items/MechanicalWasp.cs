﻿using Microsoft.Xna.Framework;
    class MechanicalWasp : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mechanical Wasp");
            Tooltip.SetDefault("Summons Mechasting");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/MechanicalWasp");
            item.consumable = true;
            item.rare = 8;
            item.width = dims.Width;
            item.useTime = 45;
            item.useStyle = 4;
            item.value = 0;
            item.maxStack = 20;
            item.useAnimation = 45;
            item.height = dims.Height;