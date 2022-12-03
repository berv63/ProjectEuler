using System.Reflection;

namespace ProjectEuler.Shared
{
    public static class EnumExtensions
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public static string GetDescription<T>(this T enumValue)
        {
            Type genericEnumType = enumValue.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(enumValue.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return enumValue.ToString();
        }
    }
}
