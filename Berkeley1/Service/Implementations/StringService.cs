using Berkeley1.Service.Interfaces;
using System;
using System.Linq;

namespace Berkeley1.Service.Implementations
{
    public class StringService : IStringService
    {
        public StringService()
        {
        }

        /// <summary>
        /// Method to return the reverse string if the value parameter.
        /// If this is null then NULL is returned.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string ReverseString(string value)
        {
            if (value == null)
            {
                return "NULL";
            }
            var strArray = value.ToCharArray();
            Array.Reverse(strArray);
            var returnString = new string(strArray);
            return returnString;
        }
    }
}
