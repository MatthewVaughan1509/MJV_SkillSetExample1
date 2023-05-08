using System;
using Berkeley1.Service.Interfaces;
using System.Linq;

namespace Berkeley1.Service.Implementations
{
    internal class DebugStringService : IStringService
    {
        public string ReverseString(string value)
        {
            if (value == null)
            {
                return "NULL";
            }
            var strArray = value.ToCharArray();
            Array.Reverse(strArray);
            var returnString = new string(strArray);
            return $"{returnString} (DEBUG)";
        }
    }
}
