using Volo.Abp.Modularity;

namespace TemplateAngular;

public abstract class TemplateAngularApplicationTestBase<TStartupModule> : TemplateAngularTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
