﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Decorator Design Pattern.";
        }
    }
}