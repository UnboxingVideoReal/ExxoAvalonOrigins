using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;namespace ExxoAvalonOrigins.Items{	class ResistantWoodCandelabra : ModItem	{		public override void SetStaticDefaults()		{			DisplayName.SetDefault("Resistant Wood Candelabra");		}		public override void SetDefaults()		{			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ResistantWoodCandelabra");			item.autoReuse = true;			item.consumable = true;			item.createTile = ModContent.TileType<Tiles.ResistantWoodCandelabra>();			item.width = dims.Width;			item.useTurn = true;			item.useTime = 10;			item.useStyle = 1;			item.maxStack = 99;			item.value = 1500;			item.useAnimation = 15;			item.height = dims.Height;		}	}}