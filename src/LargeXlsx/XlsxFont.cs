﻿/*
LargeXlsx - Minimalistic .net library to write large XLSX files

Copyright 2020 Salvatore ISAJA. All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice,
this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice,
this list of conditions and the following disclaimer in the documentation
and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED THE COPYRIGHT HOLDER ``AS IS'' AND ANY EXPRESS
OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN
NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE FOR ANY DIRECT,
INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using System;
using System.Collections.Generic;
using System.Drawing;

namespace LargeXlsx
{
    public class XlsxFont : IEquatable<XlsxFont>
    {
        public static readonly XlsxFont Default = new XlsxFont("Calibri", 11, Color.Black);

        public string FontName { get; }
        public double FontSize { get; }
        public Color Color { get; }
        public bool Bold { get; }
        public bool Italic { get; }
        public bool Strike { get; }

        public XlsxFont(string fontName, double fontSize, Color color, bool bold = false, bool italic = false, bool strike = false)
        {
            FontName = fontName;
            FontSize = fontSize;
            Color = color;
            Bold = bold;
            Italic = italic;
            Strike = strike;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as XlsxFont);
        }

        public bool Equals(XlsxFont other)
        {
            return other != null
                   && FontName == other.FontName && FontSize == other.FontSize && Color == other.Color
                   && Bold == other.Bold && Italic == other.Italic && Strike == other.Strike;
        }

        public override int GetHashCode()
        {
            var hashCode = -1593953530;
            hashCode = hashCode * -1521134295 + FontName.GetHashCode();
            hashCode = hashCode * -1521134295 + FontSize.GetHashCode();
            hashCode = hashCode * -1521134295 + Color.GetHashCode();
            hashCode = hashCode * -1521134295 + Bold.GetHashCode();
            hashCode = hashCode * -1521134295 + Italic.GetHashCode();
            hashCode = hashCode * -1521134295 + Strike.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(XlsxFont font1, XlsxFont font2)
        {
            return EqualityComparer<XlsxFont>.Default.Equals(font1, font2);
        }

        public static bool operator !=(XlsxFont font1, XlsxFont font2)
        {
            return !(font1 == font2);
        }
    }
}