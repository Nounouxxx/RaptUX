using Volo.Abp.Settings;

namespace RaptUx.Settings;

public class RaptUxSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(RaptUxSettings.MySetting1));
    }
}
