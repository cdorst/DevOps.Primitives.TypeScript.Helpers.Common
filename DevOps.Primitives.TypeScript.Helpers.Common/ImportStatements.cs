namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class ImportStatements
    {
        public static ImportStatement Import(in string exportName, in string moduleName)
            => new ImportStatement(in exportName, in moduleName);
    }
}
