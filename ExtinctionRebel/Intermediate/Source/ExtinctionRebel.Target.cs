using UnrealBuildTool;

public class ExtinctionRebelTarget : TargetRules
{
	public ExtinctionRebelTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ExtinctionRebel");
	}
}
