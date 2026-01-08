// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MPP : ModuleRules
{
	public MPP(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MPP",
			"MPP/Variant_Platforming",
			"MPP/Variant_Platforming/Animation",
			"MPP/Variant_Combat",
			"MPP/Variant_Combat/AI",
			"MPP/Variant_Combat/Animation",
			"MPP/Variant_Combat/Gameplay",
			"MPP/Variant_Combat/Interfaces",
			"MPP/Variant_Combat/UI",
			"MPP/Variant_SideScrolling",
			"MPP/Variant_SideScrolling/AI",
			"MPP/Variant_SideScrolling/Gameplay",
			"MPP/Variant_SideScrolling/Interfaces",
			"MPP/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
