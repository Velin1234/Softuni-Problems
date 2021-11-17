using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseble
    {
        public string Browse(string Url)
        {
            foreach (var @char in Url)
            {
                if (Char.IsDigit(@char))
                {
                    return "Invalid URL!";
                }
            }
            return $"Browsing: {Url}!";
        }

        public string Call(string number)
        {
            foreach (var @char in number)
            {
                if (!Char.IsDigit(@char))
                {
                    return "Invalid number!";
                }
            }
            return $"Calling... {number}";
        }

    }
}
