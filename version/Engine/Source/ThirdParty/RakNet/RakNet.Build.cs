using UnrealBuildTool;

public class RakNet : ModuleRules
{
    public RakNet(TargetInfo Target)
    {
        Type = ModuleType.External;

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicIncludePaths.Add(UEBuildConfiguration.UEThirdPartySourceDirectory + "RakNet/RakNet-master/Source/");
            PublicLibraryPaths.Add(UEBuildConfiguration.UEThirdPartySourceDirectory + "RakNet/RakNet-master/Lib/");
            PublicAdditionalLibraries.Add("RakLib.lib");
        }
    }
}