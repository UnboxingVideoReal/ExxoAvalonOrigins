using Microsoft.Xna.Framework;
    [AutoloadEquip(EquipType.Body)]
    class NickelChainmail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nickel Chainmail");
        }

        public override void SetDefaults()
        {
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/NickelChainmail");
            item.defense = 3;
            item.width = dims.Width;
            item.value = Item.sellPrice(0, 0, 0, 70);
            item.height = dims.Height;
        }
    }