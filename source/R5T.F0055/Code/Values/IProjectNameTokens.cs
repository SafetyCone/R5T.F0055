using System;

using R5T.T0131;


namespace R5T.F0055
{
	[ValuesMarker]
	public partial interface IProjectNameTokens : IValuesMarker
	{
        public string Client => Instances.NameTokens.Client;
        public string Construction => Instances.NameTokens.Construction;
		public string Library => Instances.NameTokens.Library;
		public string Server => Instances.NameTokens.Server;
    }
}