﻿using System;

using Atomix.CompilerExt.Attributes;

namespace Atomix.Core.mscorlib
{
    public class Exception
    {
        [Plug("System_Void__System_Exception__cctor__")]
        public static unsafe void ctor()
        {
            return;
        }

        [Plug("System_Void__System_Exception__ctor_System_String_")]
        public static unsafe void cctor(byte* aAddress, uint Message)
        {
            *(uint*)(aAddress + 0xC) = Message;
        }

        [Plug("System_String_System_Exception_get_Message__")]
        public static unsafe uint GetMessage(byte* aAddress)
        {
            return *(uint*)(aAddress + 0xC);
        }

        [Label("SetException")]
        public static void SetException(Exception aException)
        {
            return;
        }

        [Label("GetException")]
        public static Exception GetException()
        {
            return null;
        }
    }
}