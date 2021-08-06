using Microsoft.Xna.Framework;
    [AutoloadEquip(EquipType.Body)]
    class BronzeChainmail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bronze Chainmail");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/BronzeChainmail");
            item.defense = 2;
            item.width = dims.Width;
            item.value = Item.sellPrice(0, 0, 0, 50);
            item.height = dims.Height;
        }
    }