using UnrealBuildTool;

public class ExtinctionRebelClientTarget : TargetRules
{
	public ExtinctionRebelClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ExtinctionRebel");
	}
}
