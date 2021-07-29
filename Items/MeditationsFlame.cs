using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;namespace ExxoAvalonOrigins.Items{	class MeditationsFlame : ModItem	{		public override void SetStaticDefaults()		{			DisplayName.SetDefault("Meditation's Flame");			Tooltip.SetDefault("Tome\n+5% magic damage, -10% mana cost\n+60 mana");		}		public override void SetDefaults()		{			Rectangle dims = ExxoAvalonOrigins.getDims("Items/MeditationsFlame");			item.rare = 4;			item.width = dims.Width;			item.value = 5000;			item.height = dims.Height;            item.GetGlobalItem<ExxoAvalonOriginsGlobalItemInstance>().tome = true;        }        public override void UpdateAccessory(Player player, bool hideVisual)        {            player.magicDamage += 0.05f;            player.manaCost -= 0.1f;            player.statManaMax2 += 60;        }    }}