using System;

namespace ACM.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(string source)
        {
            string result = string.Empty;

            if(!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += " ";
                    }
                    result += letter;
                }
            }
            result.TrimStart();
            return result;
        }
    }
}
