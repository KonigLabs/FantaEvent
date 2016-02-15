﻿using System;
using System.Runtime.InteropServices;

namespace KonigLabs.SpriteEvent.SDKData.Structs
{
    /// <summary>
    /// TODO - document
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FocusPoint
    {
        public UInt32 Valid;
        public UInt32 Selected;
        public UInt32 JustFocus;
        public Rectangle Rectangle;
        public UInt32 Reserved;
    }
}
