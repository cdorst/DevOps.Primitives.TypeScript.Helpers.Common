using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class ArgumentLists
    {
        public static ArgumentList Create(params Argument[] arguments)
            => new ArgumentList(GetListItems(in arguments));

        private static List<ArgumentListAssociation> GetListItems(in Argument[] arguments)
            => arguments.Select(argument => new ArgumentListAssociation(in argument)).ToList();
    }
}
