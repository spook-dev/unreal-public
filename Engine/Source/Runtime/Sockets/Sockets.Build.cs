// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Sockets : ModuleRules
{
	public Sockets(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateIncludePaths.Add("Runtime/Sockets/Private");

		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Core",
			});
        PublicAdditionalLibraries.Add(@"C:\Users\jdenesha\Documents\git\UnrealEngine\Engine\Binaries\Win64\qwave.lib");
		PublicDefinitions.Add("SOCKETS_PACKAGE=1");
	}
}
