using Microsoft.Xna.Framework;
    class NickelPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Pickaxe");
        }
        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/NickelPickaxe");
            item.UseSound = SoundID.Item1;
            item.damage = 6;
            item.autoReuse = true;
            item.useTurn = true;
            item.scale = 1f;
            item.pick = 44;
            item.width = dims.Width;
            item.useTime = 12;
            item.knockBack = 2f;
            item.melee = true;
            item.useStyle = 1;
            item.value = 850;
            item.useAnimation = 19;
            item.height = dims.Height;
        }
    }