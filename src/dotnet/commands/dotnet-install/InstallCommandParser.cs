// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.DotNet.Cli.CommandLine;

namespace Microsoft.DotNet.Cli
{
    internal static class InstallCommandParser
    {
        public static Command Install()
        {
            return Create.Command(
                "install", "",
                Accept.NoArguments(),
                CommonOptions.HelpOption(),
                InstallToolCommandParser.InstallTool());
        }
    }
}
