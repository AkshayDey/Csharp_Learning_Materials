using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class StringExtensions
    {
        public static(string PartA, string PartB) Divide (this string original)
        {
            var size = original.Length / 2;
            return (original.Substring(0, size), original.Substring(size + 1));
        }

    }
}
