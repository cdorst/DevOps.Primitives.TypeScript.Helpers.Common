using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class StatementLists
    {
        public static StatementList Create(params Statement[] statements)
            => new StatementList(GetListItems(in statements));

        public static StatementList Create(params string[] statements)
            => Create(statements.Select(statement => new Statement(in statement)).ToArray());

        private static List<StatementListAssociation> GetListItems(in Statement[] statements)
            => statements.Select(statement => new StatementListAssociation(in statement)).ToList();
    }
}
