using Terraria;
using Terraria.ModLoader;

namespace BetterStacks.Items
{
	public class BetterStacks : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
            if (item.maxStack == 999)
            {
                if (ContainsAny(item.name, "Block", "Arrow", "Bullet", "Wall", "Fence", "Rope", "Bottle", "Gel", "Paint", "Platform", "Wood", "Shuriken", "Cobweb", "Bone"))
                {
                    item.maxStack = 9999;
                }
            }

            else if (item.maxStack == 99)
            {
                if (ContainsAny(item.name, "Acorn", "Torch", "Bar", "Hook"))
                {
                    item.maxStack = 999;
                }
            }

            // All grenades, bombs
            // Excludes:
            // * 453 - Bomb Statue
            // * 758 - Grenade Launcher
            // * 3837 - Etherian Goblin Bomber Banner
            else if (ContainsAny(item.name, "Grenade", "Bomb") && (item.type != 758 && item.type != 453 && item.type != 3837))
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
		}

        public static bool ContainsAny(string haystack, params string[] needles)
        {
            foreach (string needle in needles)
            {
                if (haystack.Contains(needle))
                    return true;
            }
            return false;
        }
    }
}
