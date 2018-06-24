namespace DevOps.Primitives.TypeScript.Helpers.Common
{
    public static class Properties
    {
        public static Property Public(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Public,
                isStatic: false,
                isReadonly: false,
                in decoratorList,
                in assignment);

        public static Property PublicReadonly(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Public,
                isStatic: false,
                isReadonly: true,
                in decoratorList,
                in assignment);

        public static Property PublicStatic(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Public,
                isStatic: true,
                isReadonly: false,
                in decoratorList,
                in assignment);

        public static Property PublicStaticReadonly(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Public,
                isStatic: true,
                isReadonly: true,
                in decoratorList,
                in assignment);

        public static Property Protected(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Protected,
                isStatic: false,
                isReadonly: false,
                in decoratorList,
                in assignment);

        public static Property ProtectedReadonly(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Protected,
                isStatic: false,
                isReadonly: true,
                in decoratorList,
                in assignment);

        public static Property ProtectedStatic(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Protected,
                isStatic: true,
                isReadonly: false,
                in decoratorList,
                in assignment);

        public static Property ProtectedStaticReadonly(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Protected,
                isStatic: true,
                isReadonly: true,
                in decoratorList,
                in assignment);

        public static Property Private(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Private,
                isStatic: false,
                isReadonly: false,
                in decoratorList,
                in assignment);

        public static Property PrivateReadonly(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Private,
                isStatic: false,
                isReadonly: true,
                in decoratorList,
                in assignment);

        public static Property PrivateStatic(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Private,
                isStatic: true,
                isReadonly: false,
                in decoratorList,
                in assignment);

        public static Property PrivateStaticReadonly(
            in string name,
            in string type,
            in string comment,
            in DecoratorList decoratorList = default,
            in Expression assignment = default)
            => new Property(
                in name,
                in type,
                in comment,
                AccessModifiers.Private,
                isStatic: true,
                isReadonly: true,
                in decoratorList,
                in assignment);
    }
}
