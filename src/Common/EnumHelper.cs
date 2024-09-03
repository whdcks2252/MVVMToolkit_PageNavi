using System.ComponentModel;
using System.Reflection;

namespace Common
{
    public static class EnumHelper
    {
        public static string ToDescription(this Enum value)
        {
            // Get the Description attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        public static T GetEnumValueFromDescription<T>(string description) where T : struct, Enum
        {
            Type type = typeof(T);
            if (!type.IsEnum) throw new ArgumentException("T must be an enumerated type");

            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                DescriptionAttribute? attribute = field.GetCustomAttribute<DescriptionAttribute>();
                if (attribute != null && attribute.Description == description)
                {
                    return (T)field.GetValue(null);
                }
            }

            throw new NullReferenceException();
        }

    }
}
