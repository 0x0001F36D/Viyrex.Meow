﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Infrastructure;
    using Interface;
    using System.Collections.Generic;

    /// <summary>
    /// Map Element
    /// </summary>
    public sealed class Map : BlockTag
    {
        #region Internal Constructors

        internal Map(StartTag startTag, EndTag endTag, IEnumerable<ISegment> children) : base(startTag, endTag, children)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public string Name { get => this.Attributes[nameof(Name)]; set => this.Attributes[nameof(Name)] = value; }

        #endregion Public Properties
    }
}