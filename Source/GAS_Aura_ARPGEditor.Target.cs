// Copyright Astiom_13

using UnrealBuildTool;
using System.Collections.Generic;

public class GAS_Aura_ARPGEditorTarget : TargetRules
{
	public GAS_Aura_ARPGEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "GAS_Aura_ARPG" } );
	}
}
