﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.NET.TestFramework
{
    public class FullMSBuildOnlyFactAttribute : FactAttribute
    {
        public FullMSBuildOnlyFactAttribute()
        {
            if (!TestContext.Current.ToolsetUnderTest.ShouldUseFullFrameworkMSBuild)
            {
                this.Skip = "This test requires Full MSBuild to run";
            }
        }
    }
}
