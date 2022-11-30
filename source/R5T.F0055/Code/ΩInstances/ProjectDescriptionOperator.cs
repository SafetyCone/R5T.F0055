using System;


namespace R5T.F0055
{
	public class ProjectDescriptionOperator : IProjectDescriptionOperator
	{
		#region Infrastructure

	    public static IProjectDescriptionOperator Instance { get; } = new ProjectDescriptionOperator();

	    private ProjectDescriptionOperator()
	    {
        }

	    #endregion
	}
}