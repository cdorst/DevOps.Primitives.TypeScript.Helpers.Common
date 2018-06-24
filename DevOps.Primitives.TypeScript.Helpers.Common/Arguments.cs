namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class Arguments
    {
        public static Argument Argument(in string literal) => new Argument(in literal);
    }
}
