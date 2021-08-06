using Microsoft.Xna.Framework;
    class BronzePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Pickaxe");
        }
        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/BronzePickaxe");
            item.UseSound = SoundID.Item1;
            item.damage = 5;
            item.autoReuse = true;
            item.useTurn = true;
            item.scale = 0.75f;
            item.pick = 35;
            item.width = dims.Width;
            item.useTime = 14;
            item.knockBack = 2f;
            item.melee = true;
            item.useStyle = 1;
            item.value = 750;
            item.useAnimation = 21;
            item.height = dims.Height;
        }
    }