using System;
using System.Linq;
using System.Reflection;

namespace Framework.Common.Extensions
{
    public static class Attributes
    {
        public static bool TryGetAttribute<TAttribute>(this ICustomAttributeProvider type) where TAttribute : Attribute
        {
            object attribute = type.GetCustomAttribute<TAttribute>();
            return (attribute != default(TAttribute));
        }

        public static bool TryGetAttribute<TAttribute>(this ICustomAttributeProvider type, out TAttribute attribute) where TAttribute : Attribute
        {
            attribute = type.GetCustomAttribute<TAttribute>();
            return (attribute != default(TAttribute));
        }

        public static TAttribute GetCustomAttribute<TAttribute>(this ICustomAttributeProvider type) where TAttribute : Attribute
        {
            return type.GetCustomAttribute<TAttribute>(false);
        }

        public static TAttribute GetCustomAttribute<TAttribute>(this ICustomAttributeProvider type, bool inherit) where TAttribute : Attribute
        {
            TAttribute[] attrs = type.GetCustomAttributes<TAttribute>(inherit);
            if (attrs != default(TAttribute[]))
                return attrs[0];

            return default(TAttribute);
        }

        public static TAttribute[] GetCustomAttributes<TAttribute>(this ICustomAttributeProvider type) where TAttribute : Attribute
        {
            return GetCustomAttributes<TAttribute>(type, false);
        }

        public static TAttribute[] GetCustomAttributes<TAttribute>(this ICustomAttributeProvider type, bool inherit) where TAttribute : Attribute
        {
            TAttribute[] attrs = type.GetCustomAttributes(typeof(TAttribute), inherit) as TAttribute[];
            if ((attrs != null) && (attrs.Length > 0))
                return attrs;

            return default(TAttribute[]);
        }

        public static T ToEnum<T>(this string inputString) where T : struct
        {
            T result;
            if (!Enum.TryParse<T>(inputString, out result))
                result = (T)Enum.Parse(typeof(T), Enum.GetNames(typeof(T)).First());

            return result;
        }

        public static TAttribute GetEnumFieldAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            return enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttribute<TAttribute>();
        }
    }
}
