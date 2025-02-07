using Terraria;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Prefixes
{
	public class Confused : ModPrefix
	{
		public Confused()
		{

		}

		public override bool CanRoll(Item item)
		{
			return false;
		}

		public override bool Autoload(ref string name)
		{
			if (base.Autoload(ref name))
			{
				mod.AddPrefix("Confused", new Confused());
			}
			return false;
		}

		public override void Apply(Item item)
		{
			Main.player[Main.myPlayer].confused = true;
		}

		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
		{
		}
	}
}