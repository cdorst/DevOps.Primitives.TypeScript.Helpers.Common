using System.Collections.Generic;

namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public class ImportStatementEqualityComparer : EqualityComparer<ImportStatement>
    {
        public static ImportStatementEqualityComparer Instance
            => new ImportStatementEqualityComparer();

        public override bool Equals(ImportStatement x, ImportStatement y)
            => x.ExportName.Name.Value.Equals(y.ExportName.Name.Value)
            && x.ModuleName.Name.Value.Equals(y.ModuleName.Name.Value);

        public override int GetHashCode(ImportStatement obj)
            => obj.ModuleName.Name.Value.GetHashCode();
    }
}
