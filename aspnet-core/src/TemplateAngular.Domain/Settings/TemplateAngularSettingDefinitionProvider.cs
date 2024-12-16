using Volo.Abp.Settings;

namespace TemplateAngular.Settings;

public class TemplateAngularSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TemplateAngularSettings.MySetting1));
    }
}
