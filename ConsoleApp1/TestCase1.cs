﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                        //this test case
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestCase1
    {
         private int i = 0;

        public void SetValue(int value)
        {

            i = value;
        }

        public void GetValue()
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
