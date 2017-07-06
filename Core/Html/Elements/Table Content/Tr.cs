﻿namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;
    using System;

    /// <summary>
    /// Tr Element
    /// </summary>
    public sealed class Tr : RequireStartElementBase
    {
        [Obsolete]
        [Deprecated]
        public string Align { get; set; }

        [NotStandardized]
        public string BgColor { get; set; }

        [Obsolete]
        [Deprecated]
        public string Char { get; set; }

        [Obsolete]
        [Deprecated]
        public string CharOff { get; set; }

        [Obsolete]
        [Deprecated]
        public string VAlign { get; set; }
    }
}