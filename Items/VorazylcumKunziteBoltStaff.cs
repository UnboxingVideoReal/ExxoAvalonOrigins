using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;namespace ExxoAvalonOrigins.Items{	class VorazylcumKunziteBoltStaff : ModItem	{		public override void SetStaticDefaults()		{			DisplayName.SetDefault("Vorazylcum-Kunzite Bolt Staff");			Tooltip.SetDefault("Fires a spread of magical bolts");		}		public override void SetDefaults()		{			Rectangle dims = ExxoAvalonOrigins.getDims("Items/VorazylcumKunziteBoltStaff");			item.magic = true;			item.damage = 92;			item.autoReuse = true;			item.shootSpeed = 6f;			item.mana = 37;			item.noMelee = true;			item.rare = 9;			item.width = dims.Width;			item.knockBack = 3f;			item.useTime = 25;			item.shoot = ModContent.ProjectileType<Projectiles.KunziteBolt>();			item.useStyle = 5;			item.value = Item.sellPrice(0, 60, 0, 0);			item.useAnimation = 25;			item.height = dims.Height;            item.UseSound = SoundID.Item43;
        }		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage,			ref float knockBack)		{			for (int num161 = 0; num161 < 10; num161++)			{				float num162 = speedX;				float num163 = speedY;				num162 += (float)Main.rand.Next(-30, 31) * 0.05f;				num163 += (float)Main.rand.Next(-30, 31) * 0.05f;				Projectile.NewProjectile(position.X, position.Y, num162, num163, type, damage, knockBack, player.whoAmI, 0f, 0f);			}			return false;		}	}}