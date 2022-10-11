using System;

using R5T.T0132;


namespace R5T.F0055
{
	[FunctionalityMarker]
	public partial interface IProjectNameOperator : IFunctionalityMarker
	{
		public string AppendToken(
			string solutionName,
			string token)
		{
			var tokenSeparator = this.GetTokenSeparator();

			var output = $"{solutionName}{tokenSeparator}{token}";
			return output;
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
			// Project name is just the unadjusted repository name. No adjustments needed.
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