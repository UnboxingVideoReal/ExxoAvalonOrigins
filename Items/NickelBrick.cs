using Microsoft.Xna.Framework;
    class NickelBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Brick");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/NickelBrick");
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.NickelBrick>();
            item.rare = 0;
            item.width = dims.Width;
            item.useTime = 10;
            item.useTurn = true;
            item.useStyle = 1;
            item.maxStack = 999;
            item.value = 0;
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }