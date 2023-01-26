using BepInEx;
using ItemManager;
using LocalizationManager;
using UnityEngine;

namespace GapFiller;

[BepInPlugin(ModGUID, ModName, ModVersion)]
[BepInIncompatibility("org.bepinex.plugins.valheim_plus")]
public class GapFiller : BaseUnityPlugin
{
	private const string ModName = "GapFiller";
	private const string ModVersion = "1.0.1";
	private const string ModGUID = "org.bepinex.plugins.gapfiller";

	public void Awake()
	{
		Localizer.Load();

		AssetBundle assets = PrefabManager.RegisterAssetBundle("gapfiller");

		Item item = new(assets, "GF_TH_Axe_Flint");
		item.Crafting.Add(CraftingTable.Workbench, 1);
		item.RequiredItems.Add("Wood", 10);
		item.RequiredItems.Add("Flint", 15);
		item.RequiredItems.Add("LeatherScraps", 5);
		item.RequiredUpgradeItems.Add("Wood", 5);
		item.RequiredUpgradeItems.Add("Flint", 7);
		item.RequiredUpgradeItems.Add("LeatherScraps", 2);

		item = new Item(assets, "GF_TH_Sword_Flint");
		item.Crafting.Add(CraftingTable.Workbench, 1);
		item.RequiredItems.Add("Wood", 10);
		item.RequiredItems.Add("Flint", 15);
		item.RequiredItems.Add("LeatherScraps", 5);
		item.RequiredUpgradeItems.Add("Wood", 5);
		item.RequiredUpgradeItems.Add("Flint", 7);
		item.RequiredUpgradeItems.Add("LeatherScraps", 2);

		item = new Item(assets, "GF_Atgeir_Flint");
		item.Crafting.Add(CraftingTable.Workbench, 1);
		item.RequiredItems.Add("Wood", 10);
		item.RequiredItems.Add("Flint", 15);
		item.RequiredItems.Add("LeatherScraps", 5);
		item.RequiredUpgradeItems.Add("Wood", 5);
		item.RequiredUpgradeItems.Add("Flint", 7);
		item.RequiredUpgradeItems.Add("LeatherScraps", 2);

		item = new Item(assets, "GF_Sword_Flint");
		item.Crafting.Add(CraftingTable.Workbench, 1);
		item.RequiredItems.Add("Wood", 5);
		item.RequiredItems.Add("Flint", 10);
		item.RequiredItems.Add("LeatherScraps", 3);
		item.RequiredUpgradeItems.Add("Wood", 3);
		item.RequiredUpgradeItems.Add("Flint", 5);
		item.RequiredUpgradeItems.Add("LeatherScraps", 1);

		item = new Item(assets, "GF_Sledge_Bronze");
		item.Crafting.Add(CraftingTable.Forge, 1);
		item.RequiredItems.Add("RoundLog", 20);
		item.RequiredItems.Add("Bronze", 30);
		item.RequiredItems.Add("DeerHide", 10);
		item.RequiredUpgradeItems.Add("RoundLog", 10);
		item.RequiredUpgradeItems.Add("Bronze", 15);
		item.RequiredUpgradeItems.Add("DeerHide", 3);

		item = new Item(assets, "GF_TH_Axe_Bronze");
		item.Crafting.Add(CraftingTable.Forge, 1);
		item.RequiredItems.Add("RoundLog", 20);
		item.RequiredItems.Add("Bronze", 30);
		item.RequiredItems.Add("DeerHide", 10);
		item.RequiredUpgradeItems.Add("RoundLog", 10);
		item.RequiredUpgradeItems.Add("Bronze", 15);
		item.RequiredUpgradeItems.Add("DeerHide", 3);

		item = new Item(assets, "GF_TH_Sword_Bronze");
		item.Crafting.Add(CraftingTable.Forge, 1);
		item.RequiredItems.Add("RoundLog", 20);
		item.RequiredItems.Add("Bronze", 30);
		item.RequiredItems.Add("DeerHide", 10);
		item.RequiredUpgradeItems.Add("RoundLog", 10);
		item.RequiredUpgradeItems.Add("Bronze", 15);
		item.RequiredUpgradeItems.Add("DeerHide", 3);

		item = new Item(assets, "GF_TH_Sword_Iron");
		item.Crafting.Add(CraftingTable.Forge, 2);
		item.RequiredItems.Add("ElderBark", 40);
		item.RequiredItems.Add("Iron", 60);
		item.RequiredItems.Add("Guck", 10);
		item.RequiredUpgradeItems.Add("ElderBark", 20);
		item.RequiredUpgradeItems.Add("Iron", 20);
		item.RequiredUpgradeItems.Add("Guck", 5);

		item = new Item(assets, "GF_Atgeir_Silver");
		item.Crafting.Add(CraftingTable.Forge, 3);
		item.RequiredItems.Add("FineWood", 20);
		item.RequiredItems.Add("Silver", 60);
		item.RequiredItems.Add("WolfFang", 5);
		item.RequiredUpgradeItems.Add("Silver", 20);
		item.RequiredUpgradeItems.Add("WolfFang", 2);

		item = new Item(assets, "GF_Sledge_Silver");
		item.Crafting.Add(CraftingTable.Forge, 3);
		item.RequiredItems.Add("FineWood", 20);
		item.RequiredItems.Add("Obsidian", 60);
		item.RequiredItems.Add("Silver", 5);
		item.RequiredUpgradeItems.Add("Obsidian", 20);
		item.RequiredUpgradeItems.Add("Silver", 2);

		item = new Item(assets, "GF_TH_Sword_Silver");
		item.Crafting.Add(CraftingTable.Forge, 3);
		item.RequiredItems.Add("FineWood", 20);
		item.RequiredItems.Add("Silver", 60);
		item.RequiredItems.Add("Obsidian", 5);
		item.RequiredUpgradeItems.Add("Silver", 20);
		item.RequiredUpgradeItems.Add("Obsidian", 2);

		item = new Item(assets, "GF_Axe_Silver");
		item.Crafting.Add(CraftingTable.Forge, 3);
		item.RequiredItems.Add("FineWood", 20);
		item.RequiredItems.Add("Silver", 40);
		item.RequiredItems.Add("Obsidian", 5);
		item.RequiredUpgradeItems.Add("Silver", 15);
		item.RequiredUpgradeItems.Add("Obsidian", 2);

		item = new Item(assets, "GF_TH_Sword_Blackmetal");
		item.Crafting.Add(CraftingTable.Forge, 4);
		item.RequiredItems.Add("FineWood", 20);
		item.RequiredItems.Add("BlackMetal", 60);
		item.RequiredItems.Add("LinenThread", 5);
		item.RequiredUpgradeItems.Add("BlackMetal", 20);
		item.RequiredUpgradeItems.Add("LinenThread", 2);

		item = new Item(assets, "GF_Sledge_Blackmetal");
		item.Crafting.Add(CraftingTable.Forge, 4);
		item.RequiredItems.Add("FineWood", 30);
		item.RequiredItems.Add("BlackMetal", 30);
		item.RequiredItems.Add("LinenThread", 30);
		item.RequiredUpgradeItems.Add("BlackMetal", 20);
		item.RequiredUpgradeItems.Add("LinenThread", 10);

		item = new Item(assets, "GF_Spear_Blackmetal");
		item.Crafting.Add(CraftingTable.Forge, 4);
		item.RequiredItems.Add("FineWood", 60);
		item.RequiredItems.Add("BlackMetal", 15);
		item.RequiredItems.Add("LinenThread", 15);
		item.RequiredUpgradeItems.Add("FineWood", 20);
		item.RequiredUpgradeItems.Add("BlackMetal", 5);
		item.RequiredUpgradeItems.Add("LinenThread", 5);
		PrefabManager.RegisterPrefab(assets, "GF_Spear_Blackmetal_Pro");

		item = new Item(assets, "GF_TH_Axe_Blackmetal");
		item.Crafting.Add(CraftingTable.Forge, 4);
		item.RequiredItems.Add("FineWood", 10);
		item.RequiredItems.Add("BlackMetal", 60);
		item.RequiredItems.Add("LinenThread", 5);
		item.RequiredUpgradeItems.Add("BlackMetal", 20);
		item.RequiredUpgradeItems.Add("LinenThread", 2);
		
		item = new Item(assets, "GF_Mace_Marble");
		item.Crafting.Add(CraftingTable.BlackForge, 1);
		item.RequiredItems.Add("Iron", 15);
		item.RequiredItems.Add("BlackMarble", 20);
		item.RequiredItems.Add("ScaleHide", 5);
		item.RequiredUpgradeItems.Add("Iron", 7);
		item.RequiredUpgradeItems.Add("BlackMarble", 10);
		item.RequiredUpgradeItems.Add("ScaleHide", 3);
		
		item = new Item(assets, "GF_TH_Axe_Marble");
		item.Crafting.Add(CraftingTable.BlackForge, 1);
		item.RequiredItems.Add("Iron", 30);
		item.RequiredItems.Add("Bronze", 20);
		item.RequiredItems.Add("ScaleHide", 5);
		item.RequiredUpgradeItems.Add("Iron", 15);
		item.RequiredUpgradeItems.Add("Bronze", 10);
		item.RequiredUpgradeItems.Add("ScaleHide", 5);
	}
}
