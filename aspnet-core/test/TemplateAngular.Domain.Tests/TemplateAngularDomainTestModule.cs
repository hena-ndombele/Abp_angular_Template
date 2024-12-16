using Volo.Abp.Modularity;

namespace TemplateAngular;

[DependsOn(
    typeof(TemplateAngularDomainModule),
    typeof(TemplateAngularTestBaseModule)
)]
public class TemplateAngularDomainTestModule : AbpModule
{

}
