using Microsoft.Xna.Framework;
        }
            Rectangle dims = ExxoAvalonOrigins.getDims("Items/TropicalShroomCap");
            item.width = dims.Width;
            item.height = dims.Height;
            item.rare = ItemRarityID.White;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 1, 0);
        }