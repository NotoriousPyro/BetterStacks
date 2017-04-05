using Terraria;
using Terraria.ModLoader;

namespace BetterStacks.Items
{
	public class BetterStacks : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			// All grenades, bombs
			// Excludes:
			// * 453 - Bomb Statue
			// * 758 - Grenade Launcher
			// * 3837 - Etherian Goblin Bomber Banner
			if (ContainsAny(item.name, "Grenade", "Bomb") && (item.type != 453 && item.type != 758 && item.type != 3837))
			{
				item.maxStack = 999;
			}

			// All potions, dynamite
			// Excludes:
			// * 456 - Potion Statue
			// * 2456 - Dynamite Fish
			else if (ContainsAny(item.name, "Potion", "Dynamite") && (item.type != 456 && item.type != 2456))
			{
				item.maxStack = 99;
			}

			else if (item.maxStack == 999)
			{
				if (ContainsAny(item.name, "Arrow", "Block", "Bone", "Bottle", "Bullet", "Cobweb", "Fence", "Gel", "Paint", "Platform", "Rope", "Shuriken", "Snowball", "Wall", "Wood"))
				{
					item.maxStack = 9999;
				}

				// * 97 - Musket Ball
				// * 279 - Throwing Knife
				// * 3379 - Bone Knife
				else if (item.type == 97 || item.type == 279 || item.type == 3379)
				{
					item.maxStack = 9999;
				}
			}

			else if (item.maxStack == 99)
			{
				if (ContainsAny(item.name, "Acorn", "Bar", "Glowstick", "Hook", "Torch"))
				{
					item.maxStack = 999;
				}

				// 1328 - Turtle Scale
				// 1329 - Tissue Sample
				// 1330 - Vertebrae
				else if (item.type >= 1328 && item.type <= 1330)
				{
					item.maxStack = 999;
				}
			}
		}

		public static bool ContainsAny(string haystack, params string[] needles)
		{
			foreach (string needle in needles)
			{
				if (haystack.Contains(needle))
				{
					return true;
				}
			}
			return false;
		}
	}
}
