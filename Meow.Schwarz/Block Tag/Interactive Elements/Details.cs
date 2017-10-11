﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Details Element
    /// </summary>
    public sealed class Details : BlockTag
    {
        #region Internal Constructors

        internal Details(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Open { get => this.Attributes[nameof(Open)]; set => this.Attributes[nameof(Open)] = value; }

        #endregion Public Properties
    }
}