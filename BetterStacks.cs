using Terraria.ModLoader;

namespace BetterStacks
{
	public class BetterStacks : Mod
	{
		public BetterStacks()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
