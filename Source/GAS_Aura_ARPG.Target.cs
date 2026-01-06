// Copyright Astiom_13

using UnrealBuildTool;
using System.Collections.Generic;

public class GAS_Aura_ARPGTarget : TargetRules
{
	public GAS_Aura_ARPGTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GAS_Aura_ARPG" } );
	}
}
