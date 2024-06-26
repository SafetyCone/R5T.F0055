using System;

using R5T.T0132;


namespace R5T.F0055
{
	[FunctionalityMarker]
	public partial interface IProjectNameOperator : IFunctionalityMarker
	{
		public string Append_Token(
			string projectName,
			string token)
		{
			var tokenSeparator = this.Get_TokenSeparator();

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
            var consoleLibraryProjectName = this.Append_Token(
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
            var constructionProjectName = this.Append_Token(
                libraryProjectName,
                Instances.ProjectNameTokens.Construction);

            return constructionProjectName;
        }

        public string Get_LibraryConstructionProjectName_FromLibraryName(string libraryName)
        {
			var libraryProjectName = this.GetLibraryProjectName_FromLibraryName(libraryName);

			var libraryConstructionProjectName = this.GetLibraryConstructionProjectName_FromLibraryProjectName(libraryProjectName);
            return libraryConstructionProjectName;
        }

        /// <inheritdoc cref="Get_WebServerProjectName_FromLibraryName(string)"/>
        public string Get_WebServerForBlazorClientProjectName_FromLibraryName(string libraryName)
		{
			var webServerForBlazorClientProjectName = this.Get_WebServerProjectName_FromLibraryName(libraryName);

			return webServerForBlazorClientProjectName;
		}

        /// <summary>
        /// Includes the server name token with the given library name to get a the project name for a web server application.
        /// </summary>
        public string Get_WebServerProjectName_FromLibraryName(string libraryName)
        {
            var webServerProjectName = this.Append_Token(
                libraryName,
                Instances.ProjectNameTokens.Server);

            return webServerProjectName;
        }

        /// <summary>
        /// Includes the client name token with the given library name to get a the project name for a Blazor client web application.
        /// </summary>
        public string Get_WebBlazorClientProjectName_FromLibraryName(string libraryName)
        {
            var webBlazorClientProjectName = this.Append_Token(
                libraryName,
                Instances.ProjectNameTokens.Client);

            return webBlazorClientProjectName;
        }

        public string GetConstructionProjectName(string projectName)
		{
			var constructionProjectName = this.Append_Token(
				projectName,
				Instances.ProjectNameTokens.Construction);

			return constructionProjectName;
		}

		public string Get_ProjectName_FromUnadjustedLibraryName(string unadjustedLibraryName)
		{
			// Project name is just the unadjusted library name. No adjustments needed.
			var projectName = unadjustedLibraryName;
			return projectName;
		}

        public string Get_ProjectName_FromLibraryName(string unadjustedLibraryName)
        {
            // Project name is just the library name. No adjustments needed.
            var projectName = unadjustedLibraryName;
            return projectName;
        }

        public string Get_TokenSeparator()
		{
			var tokenSeparator = Instances.Strings.Period;
			return tokenSeparator;
		}
	}
}