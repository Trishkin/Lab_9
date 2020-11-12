using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9.Models
{
    class StringsMethods
    {
        public void RegisterToUpper(string yourString)
        {
            Console.WriteLine(yourString.ToUpper());
        }

        public void RegisterToLower(string yourString)
        {
            Console.WriteLine(yourString.ToLower());
        }

        public string RemoveAllString(string yourString, string a)
        {
            return yourString.Replace(a, "");
        }

        public string ChangeString(string yourString, string a, string b)
        {
            return yourString.Replace(a, b);
        }

        public string InsertString(string yourString, string a, int position)
        {
            return yourString.Insert(position, a);
        }
    }
}
