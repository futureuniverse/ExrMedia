// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class ExrMediaEditor : ModuleRules
	{
		public ExrMediaEditor(TargetInfo Target)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"Core",
					"CoreUObject",
                    "ExrMedia",
					"MediaAssets",
					"UnrealEd",
                }
			);

            PrivateIncludePathModuleNames.AddRange(
                new string[] {
                    "AssetTools",
                }
            );

            PrivateIncludePaths.AddRange(
				new string[] {
					"ExrMediaEditor/Private",
                    "ExrMediaEditor/Private/Factories",
                }
			);
		}
	}
}
