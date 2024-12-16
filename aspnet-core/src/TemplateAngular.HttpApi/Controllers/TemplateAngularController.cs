using TemplateAngular.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TemplateAngular.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TemplateAngularController : AbpControllerBase
{
    protected TemplateAngularController()
    {
        LocalizationResource = typeof(TemplateAngularResource);
    }
}
