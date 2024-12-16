using TemplateAngular.Samples;
using Xunit;

namespace TemplateAngular.EntityFrameworkCore.Applications;

[Collection(TemplateAngularTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TemplateAngularEntityFrameworkCoreTestModule>
{

}
