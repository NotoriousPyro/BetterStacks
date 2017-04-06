using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace BetterStacks.Items
{
	public class BetterStacks : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			// ExcludedItemIDs
			// ItemID		Item Name						Which list?				Why?
			// 342			Tiki Torch						ItemNamesTo999			Torch
			// 343			Barrel							ItemNamesTo999			Bar
			// 682			Marrow							ItemNamesTo9999			Arrow
			// 758			Grenade Launcher				ItemNamesTo999			Grenade
			// 1706			Bar Stool						ItemNamesTo999			Bar
			// 1715			Bar								ItemNamesTo999			Bar
			// 2456			Dynamite Fish					ItemNamesTo99			Dynamite
			// 2485			Infected Scabbardfish			ItemNamesTo999			Bar
			// 2488			Tropical Barracuda				ItemNamesTo999			Bar
			// 3288			Lazure's Barrier Platform		ItemNamesTo999			Bar
			int[] ExcludedItemIDs = { 342, 343, 682, 758, 1706, 1715, 2456, 2485, 2488, 3288 };
			string[] ExcludedItemNames = { "Banner", "Statue" };

			string[] ItemNamesTo99 = { "Dynamite", "Potion" };
			string[] ItemNamesTo999 = { "Bar", "Bomb", "Glowstick", "Grenade", "Torch" };
			string[] ItemNamesTo9999 = { "Arrow", "Block", "Bullet", "Fence", "Javelin", "Platform", "Rope", "Wall" };

			// ItemIDsTo99:
			// 1134			Bottled Honey
			int[] ItemIDsTo99 = { 1134 };

			// ItemIDsTo999:
			// 27			Acorn
			// 118			Hook
			// 320			Feather
			// 1328			Turtle Scale
			// 1329			Tissue Sample
			// 1330			Vertebrae
			// 1516			Giant Harpy Feather
			// 1517			Bone Feather
			// 1518			Fire Feather
			// 1519			Ice Feather
			int[] ItemIDsTo999 = { 27, 118, 320, 1328, 1329, 1330, 1516, 1517, 1518, 1519 };

			// ItemIDsTo9999:
			// 9			Wood
			// 23			Gel
			// 31			Bottle
			// 42			Shuriken
			// 97			Musket Ball
			// 126			Bottled Water
			// 150			Cobweb
			// 154			Bone
			// 279			Throwing Knife
			// 619			Ebonwood
			// 621			Pearlwood
			// 911			Shadewood
			// 949			Snowball
			// 1729			Spooky Wood
			// 2260			Dynasty Wood
			// 2503			Boreal Wood
			// 2504			Palm Wood
			// 3111			Pink Gel
			// 3379			Bone Throwing Knife
			int[] ItemIDsTo9999 = { 9, 23, 31, 42, 97, 126, 150, 154, 279, 619, 621, 911, 949, 1729, 2260, 2503, 2504, 3379 };

			if (!ExcludedItemIDs.Contains(item.type) && !ContainsAny(item.name, ExcludedItemNames))
			{
				if (ContainsAny(item.name, ItemNamesTo99) || ItemIDsTo99.Contains(item.type))
				{
					item.maxStack = 99;
				}
				else if (ContainsAny(item.name, ItemNamesTo999) || ItemIDsTo999.Contains(item.type))
				{
					item.maxStack = 999;
				}
				else if (ContainsAny(item.name, ItemNamesTo9999) || ItemIDsTo9999.Contains(item.type))
				{
					item.maxStack = 9999;
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
