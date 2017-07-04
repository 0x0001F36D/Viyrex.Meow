﻿namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Th Element
    /// </summary>
    public sealed class Th : RequireElementBase
    {
        [Obsolete]
        public string Abbr { get; set; }

        [Obsolete]
        [Deprecated]
        public string Align { get; set; }

        [Obsolete]
        public string Axis { get; set; }

        [NotStandardized]
        public string BgColor { get; set; }

        [Obsolete]
        [Deprecated]
        public string Char { get; set; }

        [Obsolete]
        [Deprecated]
        public string CharOff { get; set; }

        public string ColSpan { get; set; }

        public string Headers { get; set; }

        public string RowSpan { get; set; }

        public string Scope { get; set; }

        [Obsolete]
        [Deprecated]
        public string VAlign { get; set; }

        [Deprecated]
        public string Width { get; set; }
    }
}