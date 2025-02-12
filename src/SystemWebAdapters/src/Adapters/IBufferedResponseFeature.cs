// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;

namespace System.Web.Adapters;

internal interface IBufferedResponseFeature
{
    Stream Stream { get; }

    bool SuppressContent { get; set; }

    void End();

    void ClearContent();
}
