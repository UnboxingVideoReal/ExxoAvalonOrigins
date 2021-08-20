using Terraria;

namespace ExxoAvalonOrigins.Buffs
			for (int i = 0; i < player.buffType.Length; i++)
            {
				int buffID = player.buffType[i];
				if (Main.debuff[buffID])
				{
					if (buffID != BuffID.Horrified || 
						buffID != BuffID.TheTongue || 
						buffID != BuffID.MoonLeech || 
						buffID != BuffID.PotionSickness ||
						buffID != BuffID.ManaSickness ||
						buffID != ModContent.BuffType<CurseofIcarus>())
                    {
						player.ClearBuff(buffID);
                    }
				}
            }
			player.meleeCrit += 10;
			player.magicCrit += 10;
			player.rangedCrit += 10;
			player.thrownCrit += 10;
			player.GetModPlayer<ExxoAvalonOriginsModPlayer>().critDamageMult += 0.3f;
			player.statDefense += 10;
			player.lifeRegen += 3;