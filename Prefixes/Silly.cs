using Terraria;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Prefixes
{
	public class Silly : ModPrefix
	{
		public Silly()
		{

		}

		public override bool CanRoll(Item item)
		{
			return false;
		}

		public override void ModifyValue(ref float valueMult)
		{
			valueMult *= 1.2f;
		}

		public override bool Autoload(ref string name)
		{
			if (base.Autoload(ref name))
			{
				mod.AddPrefix("Silly", new Silly());
			}
			return false;
		}

		public override void Apply(Item item)
		{
			Main.player[Main.myPlayer].magicCrit += 2;
			Main.player[Main.myPlayer].meleeCrit += 2;
			Main.player[Main.myPlayer].rangedCrit += 2;
		}

		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
		{
		}
	}
}