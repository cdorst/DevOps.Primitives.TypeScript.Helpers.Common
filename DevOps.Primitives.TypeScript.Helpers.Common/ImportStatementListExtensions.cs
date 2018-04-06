using Common.EntityFrameworkServices;
using static DevOps.Primitives.TypeScript.Helpers.Common.ImportStatementEqualityComparer;

namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class ImportStatementListExtensions
    {
        public static ImportStatementList Merge(this ImportStatementList instance, ImportStatementList given)
            => instance.Merge<ImportStatementList, ImportStatement, ImportStatementListAssociation>(given, Instance);
    }
}
