﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating array
            PlayerCharacter vestann = new PlayerCharacter("Vestann", 7, 45, 15, 8, "Long Bow");
            Monster goblin = new Monster("Goblin", 3, 15, 13, 4, "Dagger");

            //Opening statement
            Console.WriteLine("Hello, and welcome to this text adventure\n");



        }
    }
}
