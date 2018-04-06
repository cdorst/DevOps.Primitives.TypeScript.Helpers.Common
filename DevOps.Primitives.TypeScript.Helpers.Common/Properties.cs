namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class Properties
    {
        public static Property Public(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Public,
                isStatic: false,
                isReadonly: false,
                decoratorList,
                assignment);

        public static Property PublicReadonly(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Public,
                isStatic: false,
                isReadonly: true,
                decoratorList,
                assignment);

        public static Property PublicStatic(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Public,
                isStatic: true,
                isReadonly: false,
                decoratorList,
                assignment);

        public static Property PublicStaticReadonly(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Public,
                isStatic: true,
                isReadonly: true,
                decoratorList,
                assignment);

        public static Property Protected(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Protected,
                isStatic: false,
                isReadonly: false,
                decoratorList,
                assignment);

        public static Property ProtectedReadonly(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Protected,
                isStatic: false,
                isReadonly: true,
                decoratorList,
                assignment);

        public static Property ProtectedStatic(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Protected,
                isStatic: true,
                isReadonly: false,
                decoratorList,
                assignment);

        public static Property ProtectedStaticReadonly(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Protected,
                isStatic: true,
                isReadonly: true,
                decoratorList,
                assignment);

        public static Property Private(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Private,
                isStatic: false,
                isReadonly: false,
                decoratorList,
                assignment);

        public static Property PrivateReadonly(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Private,
                isStatic: false,
                isReadonly: true,
                decoratorList,
                assignment);

        public static Property PrivateStatic(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Private,
                isStatic: true,
                isReadonly: false,
                decoratorList,
                assignment);

        public static Property PrivateStaticReadonly(string name, string type, string comment, DecoratorList decoratorList = null, Expression assignment = null)
            => new Property(
                name,
                type,
                comment,
                AccessModifiers.Private,
                isStatic: true,
                isReadonly: true,
                decoratorList,
                assignment);
    }
}
