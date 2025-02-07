using Terraria;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Prefixes
{
	public class Bogus : ModPrefix
	{
		public Bogus()
		{

		}

		public override PrefixCategory Category => PrefixCategory.Accessory;

		public override void ModifyValue(ref float valueMult)
		{
			valueMult *= 1.25f;
		}

		public override bool Autoload(ref string name)
		{
			if (base.Autoload(ref name))
			{
				mod.AddPrefix("Bogus", new Bogus());
			}
			return false;
		}

		public override void Apply(Item item)
		{
			Main.player[Main.myPlayer].magicCrit += 6;
			Main.player[Main.myPlayer].meleeCrit += 6;
			Main.player[Main.myPlayer].rangedCrit += 6;
		}

		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
		{
		}
	}
}