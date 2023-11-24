using System.Reflection;

namespace Base.Extensions
{
    public static class TypeExtensions
    {
        public static IEnumerable<PropertyInfo> GetProperties<T_Attribute>(this Type type)
            where T_Attribute : Attribute
        {
            return type.GetProperties(typeof(T_Attribute));
        }

        public static IEnumerable<PropertyInfo> GetProperties(this Type type, Type attributeType)
        {
            foreach (var property in type.GetProperties())
            {
                if (property.GetCustomAttribute(attributeType) is not null)
                    yield return property;
            }
        }

        public static bool IsStructurized(this Type type)
        {
            return !(type.IsPrimitive || type.IsArray || type.IsSZArray || type == typeof(string) || type == typeof(object));
        }
    }
}
