using Microsoft.Xna.Framework;
    class ZincWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zinc Watch");
            Tooltip.SetDefault("Tells the time");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/ZincWatch");
            item.width = dims.Width;
            item.accessory = true;
            item.value = 1500;
            item.height = dims.Height;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.accWatch < 2) player.accWatch = 2;
        }
    }