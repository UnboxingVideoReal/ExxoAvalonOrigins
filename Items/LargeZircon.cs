using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;namespace ExxoAvalonOrigins.Items{	class LargeZircon : ModItem	{		public override void SetStaticDefaults()		{			DisplayName.SetDefault("Large Zircon");			Tooltip.SetDefault("For Capture the Gem. It drops when you die");		}		public override void SetDefaults()		{			item.CloneDefaults(ItemID.LargeAmber);			Rectangle dims = item.modItem.GetDims();			item.rare = ItemRarityID.Blue;			item.width = dims.Width;			item.height = dims.Height;		}	}}