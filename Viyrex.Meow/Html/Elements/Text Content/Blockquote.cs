﻿namespace Viyrex.Meow.Html.Elements
{
    public sealed class Blockquote : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        public string Cite { get; set; }
    }
}
