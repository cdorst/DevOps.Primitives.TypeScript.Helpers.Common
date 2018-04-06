namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class ImportStatements
    {
        public static ImportStatement Import(string exportName, string moduleName)
            => new ImportStatement(exportName, moduleName);
    }
}
