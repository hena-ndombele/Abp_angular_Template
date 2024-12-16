using Volo.Abp.Modularity;

namespace TemplateAngular;

/* Inherit from this class for your domain layer tests. */
public abstract class TemplateAngularDomainTestBase<TStartupModule> : TemplateAngularTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
