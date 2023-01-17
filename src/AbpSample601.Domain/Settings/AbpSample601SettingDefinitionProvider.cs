using Volo.Abp.Settings;

namespace AbpSample601.Settings;

public class AbpSample601SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpSample601Settings.MySetting1));
    }
}
