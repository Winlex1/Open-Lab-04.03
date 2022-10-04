using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            string str = original;
            if(str.Length > 2)
            {
                return original.Substring(1, original.Length - 2);
            }
            else if(str.Length == 2)
            {
                return string.Empty;
            }
            else
            {
                return original;
            }
        }
    }
}
