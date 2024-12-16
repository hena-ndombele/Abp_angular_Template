using Volo.Abp.Modularity;

namespace TemplateAngular;

[DependsOn(
    typeof(TemplateAngularApplicationModule),
    typeof(TemplateAngularDomainTestModule)
)]
public class TemplateAngularApplicationTestModule : AbpModule
{

}
