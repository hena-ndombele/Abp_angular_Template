using Microsoft.Extensions.Localization;
using TemplateAngular.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TemplateAngular;

[Dependency(ReplaceServices = true)]
public class TemplateAngularBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TemplateAngularResource> _localizer;

    public TemplateAngularBrandingProvider(IStringLocalizer<TemplateAngularResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
