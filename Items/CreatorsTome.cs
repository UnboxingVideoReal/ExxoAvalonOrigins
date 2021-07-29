using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;namespace ExxoAvalonOrigins.Items{	class CreatorsTome : ModItem	{		public override void SetStaticDefaults()		{			DisplayName.SetDefault("Creator's Tome");			Tooltip.SetDefault("Tome\n+20% damage, +5% critical strike chance, -20% mana cost\n25% chance to not consume ammo, 10 defense, +100 HP, +100 mana");		}		public override void SetDefaults()		{			Rectangle dims = ExxoAvalonOrigins.getDims("Items/CreatorsTome");			item.rare = 8;			item.width = dims.Width;			item.value = 150000;			item.height = dims.Height;            item.GetGlobalItem<ExxoAvalonOriginsGlobalItemInstance>().tome = true;        }        public override void UpdateAccessory(Player player, bool hideVisual)        {            player.magicDamage += 0.2f;            player.minionDamage += 0.2f;            player.meleeDamage += 0.2f;            player.rangedDamage += 0.2f;            player.thrownDamage += 0.2f;            player.meleeCrit += 5;            player.magicCrit += 5;            player.rangedCrit += 5;            player.thrownCrit += 5;            player.manaCost -= 0.2f;            player.statDefense += 10;            player.statLifeMax2 += 100;            player.statManaMax2 += 100;        }    }}