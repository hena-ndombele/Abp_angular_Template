using System;
using System.Collections.Generic;
using System.Text;
using TemplateAngular.Localization;
using Volo.Abp.Application.Services;

namespace TemplateAngular;

/* Inherit your application services from this class.
 */
public abstract class TemplateAngularAppService : ApplicationService
{
    protected TemplateAngularAppService()
    {
        LocalizationResource = typeof(TemplateAngularResource);
    }
}
