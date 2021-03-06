﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace FxCopAnalyzersSetup
{
    // Avoid uninstantiated internal classes
    // Package is used by VS
#pragma warning disable CA1812
    // https://github.com/dotnet/roslyn-analyzers/issues/1191
#pragma warning disable CA1823 // Avoid unused private fields
    [Guid(PackageGuid)]
    class FxCopAnalyzersPackage : Package
    {
        private const string PackageGuid = "4A41D270-A97F-4639-A352-28732FC410E4";
    }
}
