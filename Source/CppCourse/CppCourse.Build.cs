// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CppCourse : ModuleRules
{
	public CppCourse(ReadOnlyTargetRules Target) : base(Target)
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
			"CppCourse",
			"CppCourse/Variant_Platforming",
			"CppCourse/Variant_Platforming/Animation",
			"CppCourse/Variant_Combat",
			"CppCourse/Variant_Combat/AI",
			"CppCourse/Variant_Combat/Animation",
			"CppCourse/Variant_Combat/Gameplay",
			"CppCourse/Variant_Combat/Interfaces",
			"CppCourse/Variant_Combat/UI",
			"CppCourse/Variant_SideScrolling",
			"CppCourse/Variant_SideScrolling/AI",
			"CppCourse/Variant_SideScrolling/Gameplay",
			"CppCourse/Variant_SideScrolling/Interfaces",
			"CppCourse/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
