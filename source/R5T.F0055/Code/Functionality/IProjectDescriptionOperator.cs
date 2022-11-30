using System;

using R5T.T0132;


namespace R5T.F0055
{
	[FunctionalityMarker]
	public partial interface IProjectDescriptionOperator : IFunctionalityMarker
	{
		public string GetConsoleProjectDescription_FromSolutionDescription(string solutionDescription)
		{
			// The console project should have the same description as the solution.
			var consoleProjectDescription = solutionDescription;
			return consoleProjectDescription;
		}
	}
}