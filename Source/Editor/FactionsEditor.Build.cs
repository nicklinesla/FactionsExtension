// Copyright 2015-2018 Piperift. All Rights Reserved.

using UnrealBuildTool;

public class FactionsEditor : ModuleRules
{
	public FactionsEditor(ReadOnlyTargetRules TargetRules) : base(TargetRules)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;


		PublicIncludePaths.Add("Editor/Public");

		PrivateIncludePaths.Add("Editor/Private");


		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"InputCore"
			// ... add other public dependencies that you statically link with here ...
		});

		PrivateDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"AppFramework",
			"Engine",
			"UnrealEd",
			"Slate",
			"SlateCore",
			"AssetTools",
			"EditorStyle",
			"GraphEditor",
			"Kismet",
			"PropertyEditor",
			"BlueprintGraph",
			"DetailCustomizations",
			"Settings",
			"Factions"
			// ... add private dependencies that you statically link with here ...
		});

		DynamicallyLoadedModuleNames.AddRange(new string[] {
			// ... add any modules that your module loads dynamically here ...
		});
	}
}
