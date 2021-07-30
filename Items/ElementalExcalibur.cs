using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;namespace ExxoAvalonOrigins.Items{	class ElementalExcalibur : ModItem	{		public override void SetStaticDefaults()		{			DisplayName.SetDefault("Elemental Excalibur");		}		public override void SetDefaults()		{			Rectangle dims = ExxoAvalonOrigins.getDims("Items/ElementalExcalibur");			item.damage = 165;			item.autoReuse = true;
			item.UseSound = SoundID.Item1;			item.scale = 1.2f;			item.shootSpeed = 13f;			item.rare = 9;			item.noMelee = false;			item.width = dims.Width;			item.useTime = 15;			item.knockBack = 8.5f;			item.shoot = ModContent.ProjectileType<Projectiles.ElementBeam>();			item.melee = true;			item.useStyle = 1;			item.value = Item.sellPrice(0, 90, 0, 0);			item.useAnimation = 10;			item.height = dims.Height;		}
		public override Color? GetAlpha(Color lightColor)		{			return new Color(255, 255, 255, 255);		}	}}