﻿namespace Meow.Html.Elements
{
    using Meow.Html.Auxiliaries;
    using Meow.Html.Infrastructure;

    /// <summary>
    /// FrameSet Element
    /// </summary>
    [Deprecated]
    public sealed class FrameSet : NormalElementBase
    {
        public string Cols { get; set; }

        public string Rows { get; set; }
    }
}