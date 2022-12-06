using System;

using R5T.T0132;


namespace R5T.F0055
{
	[FunctionalityMarker]
	public partial interface IProjectNameOperator : IFunctionalityMarker
	{
		public string AppendToken(
			string projectName,
			string token)
		{
			var tokenSeparator = this.GetTokenSeparator();

			var output = $"{projectName}{tokenSeparator}{token}";
			return output;
		}

		public string GetConsoleProjectName_FromSolutionName(string solutionName)
		{
			// The console project should have the same name as the solution.
			var consoleProjectName = solutionName;
			return consoleProjectName;
		}

        public string GetConsoleProjectName_FromLibraryName(string libraryName)
        {
            // Console project name is just the library name. No adjustments needed.
            var consoleProjectName = libraryName;
            return consoleProjectName;
        }

        public string GetConsoleLibraryProjectName_FromConsoleProjectName(string consoleProjectName)
        {
            var consoleLibraryProjectName = this.AppendToken(
				consoleProjectName,
				Instances.ProjectNameTokens.Library);

            return consoleLibraryProjectName;
        }

        public string GetConsoleLibraryProjectName_FromLibraryName(string libraryName)
        {
			var consoleProjectName = this.GetConsoleProjectName_FromLibraryName(libraryName);

			var consoleLibraryProjectName = this.GetConsoleLibraryProjectName_FromConsoleProjectName(consoleProjectName);
            return consoleLibraryProjectName;
        }

        public string GetLibraryProjectName_FromLibraryName(string libraryName)
        {
			// The library project name is just the library name. No adjustment needed.
			var libraryProjectName = libraryName;
			return libraryProjectName;
        }

        public string GetLibraryConstructionProjectName_FromLibraryProjectName(string libraryProjectName)
        {
            var constructionProjectName = this.AppendToken(
                libraryProjectName,
                Instances.ProjectNameTokens.Construction);

            return constructionProjectName;
        }

        public string GetLibraryConstructionProjectName_FromLibraryName(string libraryName)
        {
			var libraryProjectName = this.GetLibraryProjectName_FromLibraryName(libraryName);

			var libraryConstructionProjectName = this.GetLibraryConstructionProjectName_FromLibraryProjectName(libraryProjectName);
            return libraryConstructionProjectName;
        }

		public string GetWebServerForBlazorClientProjectName_FromLibraryName(string libraryName)
		{
			var webServerForBlazorClientProjectName = this.GetWebServerProjectName_FromLibraryName(libraryName);

			return webServerForBlazorClientProjectName;
		}

        public string GetWebServerProjectName_FromLibraryName(string libraryName)
        {
            var webServerProjectName = this.AppendToken(
                libraryName,
                Instances.ProjectNameTokens.Server);

            return webServerProjectName;
        }

        public string GetWebBlazorClientProjectName_FromLibraryName(string libraryName)
        {
            var webBlazorClientProjectName = this.AppendToken(
                libraryName,
                Instances.ProjectNameTokens.Client);

            return webBlazorClientProjectName;
        }

        public string GetConstructionProjectName(string projectName)
		{
			var constructionProjectName = this.AppendToken(
				projectName,
				Instances.ProjectNameTokens.Construction);

			return constructionProjectName;
		}

		public string GetProjectName_FromUnadjustedLibraryName(string unadjustedLibraryName)
		{
			// Project name is just the unadjusted library name. No adjustments needed.
			var projectName = unadjustedLibraryName;
			return projectName;
		}

        public string GetProjectName_FromLibraryName(string unadjustedLibraryName)
        {
            // Project name is just the library name. No adjustments needed.
            var projectName = unadjustedLibraryName;
            return projectName;
        }

        public string GetTokenSeparator()
		{
			var tokenSeparator = Instances.Strings.Period;
			return tokenSeparator;
		}
	}
}