using System;


namespace R5T.F0055
{
	public class ProjectNameOperator : IProjectNameOperator
	{
		#region Infrastructure

	    public static IProjectNameOperator Instance { get; } = new ProjectNameOperator();

	    private ProjectNameOperator()
	    {
        }

	    #endregion
	}
}