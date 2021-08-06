using Microsoft.Xna.Framework;
    class NickelBroadsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Broadsword");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/NickelBroadsword");
            item.damage = 11;
            item.useTurn = true;
            item.scale = 1.15f;
            item.width = dims.Width;
            item.useTime = 21;
            item.knockBack = 5.2f;
            item.melee = true;
            item.useStyle = 1;
            item.value = 1000;
            item.useAnimation = 21;
            item.height = dims.Height;
        }
    }