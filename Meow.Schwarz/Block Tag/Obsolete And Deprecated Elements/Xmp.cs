﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Xmp Element
    /// </summary>
    [Obsolete]
    public sealed class Xmp : BlockTag
    {
        #region Internal Constructors

        internal Xmp(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors
    }
}