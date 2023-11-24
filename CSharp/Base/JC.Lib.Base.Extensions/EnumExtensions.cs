using System.Reflection;

namespace Base.Extensions
{
    public static class EnumExtensions
    {
        public static T_Attribute? GetAttribute<T_Attribute>(this Enum value)
            where T_Attribute : Attribute
        {
            var fieldInfo = value.GetType().GetField(value.ToString())!;
            var attribute = fieldInfo.GetCustomAttribute<T_Attribute>();

            return attribute;
        }
    }
}
