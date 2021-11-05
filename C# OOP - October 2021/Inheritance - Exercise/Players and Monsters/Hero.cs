﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string name;
        private int level;

        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Name} Level: {this.Level}";
        }
    }
}
