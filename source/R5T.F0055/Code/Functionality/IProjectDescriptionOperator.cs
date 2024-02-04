using System;
using System.Net.Mail;
using R5T.T0132;


namespace R5T.F0055
{
	[FunctionalityMarker]
	public partial interface IProjectDescriptionOperator : IFunctionalityMarker
	{
        public string GetWebServerForBlazorClientProjectDescription_FromLibraryName(string libraryName)
        {
            var webServerForBlazorClientProjectDescription = $"Server for the {libraryName} Blazor client.";
            return webServerForBlazorClientProjectDescription;
        }

        public string GetWebServerForStaticRazorComponentsProjectDescription_FromLibraryName(string libraryName)
        {
            var webServerForStaticRazorComponentsProjectDescription = $"Server for the {libraryName} static website generated using Razor components.";
            return webServerForStaticRazorComponentsProjectDescription;
        }

        public string GetWebBlazorClientProjectDescription_FromLibraryName(string libraryName)
        {
            var webBlazorClientProjectDescription = $"Blazor client for the {libraryName} project.";
            return webBlazorClientProjectDescription;
        }

        public string GetLibraryConstructionProjectDescription_FromLibraryName(string libraryName)
        {
            var libraryProjectName = ProjectNameOperator.Instance.GetLibraryProjectName_FromLibraryName(libraryName);

            var libraryConstructionProjectDescription = this.GetLibraryConstructionProjectDescription_FromLibraryProjectName(libraryProjectName);
            return libraryConstructionProjectDescription;
        }

        public string GetLibraryConstructionProjectDescription_FromLibraryProjectName(string libraryProjectName)
        {
            var libraryConstructionProjectDescription = $"Construction console project for the {libraryProjectName} library project.";
            return libraryConstructionProjectDescription;
        }

        public string Get_ProjectDescription_FromLibraryDescription(string libraryDescription)
        {
            // The project should have the same description as the library.
            var projectDescription = libraryDescription;
            return projectDescription;
        }

        public string GetLibraryProjectDescription_FromLibraryDescription(string libraryDescription)
        {
            // The library project should have the same description as the library.
            var libraryProjectDescription = libraryDescription;
            return libraryProjectDescription;
        }

        public string GetConsoleLibraryProjectDescription_FromConsoleProjectName(string consoleProjectName)
        {
            var consoleLibraryProjectDescription = $"Library project for the {consoleProjectName} console project.";
            return consoleLibraryProjectDescription;
        }

        public string GetConsoleLibraryProjectDescription_FromLibraryName(string libraryName)
        {
            var consoleProjectName = ProjectNameOperator.Instance.GetConsoleProjectName_FromLibraryName(libraryName);

            var consoleProjectDescription = this.GetConsoleLibraryProjectDescription_FromConsoleProjectName(consoleProjectName);
            return consoleProjectDescription;
        }

        public string GetConsoleProjectDescription_FromLibraryDescription(string libraryDescription)
        {
            // The console project should have the same description as the library.
            var consoleProjectDescription = libraryDescription;
            return consoleProjectDescription;
        }

        public string GetConsoleProjectDescription_FromSolutionDescription(string solutionDescription)
		{
			// The console project should have the same description as the solution.
			var consoleProjectDescription = solutionDescription;
			return consoleProjectDescription;
		}
	}
}