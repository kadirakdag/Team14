using UnrealBuildTool;

public class ExtinctionRebelEditorTarget : TargetRules
{
	public ExtinctionRebelEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ExtinctionRebel");
	}
}
