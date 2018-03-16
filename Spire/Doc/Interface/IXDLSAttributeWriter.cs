﻿namespace Spire.Doc.Interface
{
    using System;
    using System.Drawing;

    public interface IXDLSAttributeWriter
    {
        void WriteValue(string name, bool value);
        void WriteValue(string name, DateTime value);
        void WriteValue(string name, double value);
        void WriteValue(string name, Color value);
        void WriteValue(string name, Enum value);
        void WriteValue(string name, int value);
        void WriteValue(string name, float value);
        void WriteValue(string name, string value);
    }
}
