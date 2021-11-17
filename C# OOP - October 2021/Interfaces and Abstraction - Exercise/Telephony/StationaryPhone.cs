using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            foreach (var @char in number)
            {
                if (!Char.IsDigit(@char))
                {
                    return "Invalid number!";
                }
            }
            return $"Dialing... {number}";
        }
    }
}
