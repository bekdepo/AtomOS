﻿using System;

using Atomix.CompilerExt;
using Atomix.CompilerExt.Attributes;
using Atomix.Core;

namespace Atomix.Shell
{
    [Application(CPUArch.x86)]
    public class Startx86
    {
        public static int AddNums2(int a, int b)
        {
            return (a + b);
        }

        public static int AddNums(int a, int b)
        {
            return AddNums2(a, b) * 2;
        }

        public static void main(char[] args)
        {
            AddNums(0, 0);
            while (true) ;
        }
    }
}
