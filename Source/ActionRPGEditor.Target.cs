// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ActionRPGEditorTarget : TargetRules
{
	public ActionRPGEditorTarget(TargetInfo Target)
		: base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.AddRange(new[] { "ActionRPG" });

		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;

		DefaultBuildSettings = BuildSettingsVersion.V5;
	}
}
