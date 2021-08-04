using Microsoft.Xna.Framework;using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Terraria;using Terraria.ModLoader;using Terraria.ID;using Terraria.ObjectData;using Terraria.Localization;namespace ExxoAvalonOrigins.Tiles{	public class TroxiniumOre : ModTile	{		public override void SetDefaults()		{			mineResist = 4f;			AddMapEntry(Color.Goldenrod, LanguageManager.Instance.GetText("Troxinium"));			Main.tileSolid[Type] = true;			Main.tileMergeDirt[Type] = true;            Main.tileSpelunker[Type] = true;            drop = mod.ItemType("TroxiniumOre");            soundType = SoundID.Tink;            soundStyle = 1;            minPick = 150;            dustType = 162;        }        public override bool CanExplode(int i, int j)
        {
            return false;
        }
    }}