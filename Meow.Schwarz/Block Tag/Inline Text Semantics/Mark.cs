﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Mark Element
    /// </summary>
    public sealed class Mark : BlockTag
    {
        #region Internal Constructors

        internal Mark(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors
    }
}