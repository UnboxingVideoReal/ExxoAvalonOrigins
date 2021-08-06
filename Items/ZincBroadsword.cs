using Microsoft.Xna.Framework;
    class ZincBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zinc Broadsword");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/ZincBroadsword");
            item.damage = 13;
            item.useTurn = true;
            item.scale = 1.12f;
            item.width = dims.Width;
            item.useTime = 23;
            item.knockBack = 5.2f;
            item.melee = true;
            item.useStyle = 1;
            item.value = 1500;
            item.useAnimation = 23;
            item.height = dims.Height;
        }
    }