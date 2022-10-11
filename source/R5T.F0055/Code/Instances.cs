using System;

using R5T.F0044;
using R5T.Z0000;


namespace R5T.F0055
{
    public static class Instances
    {
        public static INameTokens NameTokens { get; } = F0044.NameTokens.Instance;
        public static IProjectNameTokens ProjectNameTokens { get; } = F0055.ProjectNameTokens.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
    }
}