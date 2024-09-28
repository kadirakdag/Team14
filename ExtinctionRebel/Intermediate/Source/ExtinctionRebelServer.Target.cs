using UnrealBuildTool;

public class ExtinctionRebelServerTarget : TargetRules
{
	public ExtinctionRebelServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ExtinctionRebel");
	}
}
