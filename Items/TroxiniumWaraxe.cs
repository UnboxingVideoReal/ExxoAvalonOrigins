using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ExxoAvalonOrigins.Items
{
	class TroxiniumWaraxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Troxinium Waraxe");
		}
		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/TroxiniumWaraxe");
			item.UseSound = SoundID.Item1;
			item.damage = 45;
			item.autoReuse = true;
			item.useTurn = true;
			item.scale = 1.2f;
			item.axe = 22;
			item.rare = ItemRarityID.Pink;
			item.width = dims.Width;
			item.useTime = 30;
			item.useAnimation = 30;
			item.knockBack = 6.5f;
			item.melee = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(0, 3, 40, 0);
			item.height = dims.Height;
			if (!Main.dedServ)
			{
				item.GetGlobalItem<ItemUseGlow>().glowTexture = mod.GetTexture("Items/TroxiniumWaraxe_Glow");
			}
		}
		public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
		{
			Texture2D texture = mod.GetTexture("Items/TroxiniumWaraxe_Glow");
			spriteBatch.Draw
			(
				texture,
				new Vector2
				(
					item.position.X - Main.screenPosition.X + item.width * 0.5f,
					item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
				),
				new Rectangle(0, 0, texture.Width, texture.Height),
				Color.White,
				rotation,
				texture.Size() * 0.5f,
				scale,
				SpriteEffects.None,
				0f
			);
		}
	}
}