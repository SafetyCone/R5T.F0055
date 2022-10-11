using System;


namespace R5T.F0055
{
	public class ProjectNameTokens : IProjectNameTokens
	{
		#region Infrastructure

	    public static IProjectNameTokens Instance { get; } = new ProjectNameTokens();

	    private ProjectNameTokens()
	    {
        }

	    #endregion
	}
}