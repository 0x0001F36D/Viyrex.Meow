﻿using System;

namespace Viyrex.ML.Html.Elements
{
    public sealed class H5 : ElementBase
    {
        public override ElementType ElementType => ElementType.Normal;

        [Obsolete]
        public string Align { get; set; }
    }
}
