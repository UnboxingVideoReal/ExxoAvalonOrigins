using Microsoft.Xna.Framework;
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
	class WaterXeradonBucket : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Water Xeradon Bucket");
		}

		public override void SetDefaults()
		{
			Rectangle dims = ExxoAvalonOrigins.getDims("Items/WaterXeradonBucket");
			item.autoReuse = true;
			item.width = dims.Width;
			item.useTurn = true;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.maxStack = 99;
			item.useAnimation = 15;
			item.height = dims.Height;
		}

		public override bool UseItem(Player player)
		{
			if (Main.tile[Player.tileTargetX, Player.tileTargetY].liquid < 200 &&
			    (!Main.tile[Player.tileTargetX, Player.tileTargetY].nactive() ||
			     !Main.tileSolid[(int) Main.tile[Player.tileTargetX, Player.tileTargetY].type] ||
			     Main.tileSolidTop[(int) Main.tile[Player.tileTargetX, Player.tileTargetY].type]))
			{
				
				if (Main.tile[Player.tileTargetX, Player.tileTargetY].liquid == 0 || Main.tile[Player.tileTargetX, Player.tileTargetY].liquidType() == 1)
				{
					Main.PlaySound(SoundID.Splash, (int)player.position.X, (int)player.position.Y, 1);
					for (int num257 = Player.tileTargetX - 1; num257 <= Player.tileTargetX + 1; num257++)
					{
						for (int num258 = Player.tileTargetY - 1; num258 <= Player.tileTargetY + 1; num258++)
						{
							Main.tile[num257, num258].liquidType(0);
							Main.tile[num257, num258].liquid = 255;
							WorldGen.SquareTileFrame(num257, num258, true);
							if (Main.netMode == NetmodeID.MultiplayerClient)
							{
								NetMessage.sendWater(num257, num258);
							}
						}
					}
					player.inventory[player.selectedItem].stack--;
					player.PutItemInInventory(ModContent.ItemType<EmptyXeradonBucket>(), player.selectedItem);
					player.itemTime = player.inventory[player.selectedItem].useTime;
				}
				else if (Main.tile[Player.tileTargetX, Player.tileTargetY].liquid < 200 &&
				         (!Main.tile[Player.tileTargetX, Player.tileTargetY].nactive() ||
				          !Main.tileSolid[(int) Main.tile[Player.tileTargetX, Player.tileTargetY].type] ||
				          Main.tileSolidTop[(int) Main.tile[Player.tileTargetX, Player.tileTargetY].type]))
				{
					if (Main.tile[Player.tileTargetX, Player.tileTargetY].liquid == 0 || Main.tile[Player.tileTargetX, Player.tileTargetY].liquidType() == 0)
					{
						Main.PlaySound(SoundID.Splash, (int)player.position.X, (int)player.position.Y, 1);
						for (int num259 = Player.tileTargetX - 1; num259 <= Player.tileTargetX + 1; num259++)
						{
							for (int num260 = Player.tileTargetY - 1; num260 <= Player.tileTargetY + 1; num260++)
							{
								Main.tile[num259, num260].liquidType(0);
								Main.tile[num259, num260].liquid = 255;
								WorldGen.SquareTileFrame(num259, num260, true);
								if (Main.netMode == NetmodeID.MultiplayerClient)
								{
									NetMessage.sendWater(num259, num260);
								}
							}
						}
						player.inventory[player.selectedItem].stack--;
						player.PutItemInInventory(ModContent.ItemType<EmptyXeradonBucket>(), player.selectedItem);
						player.itemTime = player.inventory[player.selectedItem].useTime;
					}
				}
			}

			return false;
		}
	}
}