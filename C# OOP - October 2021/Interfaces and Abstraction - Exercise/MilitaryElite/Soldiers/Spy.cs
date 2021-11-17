﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }

        public override string ToString()
            => $"{base.ToString()}{Environment.NewLine}Code Number: {CodeNumber}";
    }
}
