using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class ImportStatementLists
    {
        public static ImportStatementList ImportList(params ImportStatement[] imports)
            => new ImportStatementList(GetListItems(in imports));

        private static List<ImportStatementListAssociation> GetListItems(in ImportStatement[] imports)
            => imports.Select(import => new ImportStatementListAssociation(in import)).ToList();
    }
}
