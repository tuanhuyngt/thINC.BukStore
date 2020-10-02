using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using thINC.BukStore.Queries.Container;

namespace thINC.BukStore.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}