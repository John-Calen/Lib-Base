using JC.Lib.Base.Strings.Models;
using System.Text.RegularExpressions;

namespace JC.Lib.Base.Strings.Extensions
{
    public static class StringHelper
    {
        public static string TabAllText(this string text, int count, TabType tabType = TabType.TAB)
        {
            string tabLine = getTabLine(count, tabType);
            return tabLine + Regex.Replace
            (
                text,
                "\n",
                (match) => "\n" + tabLine
            );
        }

        private static string getTabLine(int count, TabType tabType)
        {
            var chars = new char[count];
            var character = tabType switch
            {
                TabType.SPACE => ' ',
                TabType.TAB => '\t'
            };

            for (int index = 0; index < count; index++)
                chars[index] = character;

            return new string(chars);
        }
    }
}
