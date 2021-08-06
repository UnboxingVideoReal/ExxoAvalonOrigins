using Microsoft.Xna.Framework;
    class BronzeBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Bar");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/BronzeBar");
            item.autoReuse = true;
            item.useTurn = true;
            item.maxStack = 999;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.PlacedBars>();
            item.placeStyle = 18;
            item.width = dims.Width;
            item.useTime = 10;
            item.value = Item.sellPrice(0, 0, 2, 40);
            item.useStyle = 1;
            item.useAnimation = 15;
            item.height = dims.Height;
        }
    }