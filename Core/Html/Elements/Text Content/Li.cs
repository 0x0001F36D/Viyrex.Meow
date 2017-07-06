﻿namespace Meow.Html.Elements
{
    using Meow.Auxiliary;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// Li Element
    /// </summary>
    public sealed class Li : RequireStartElementBase
    {
        [Deprecated]
        public string Type { get; set; }

        public string Value { get; set; }
    }
}