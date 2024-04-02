using System;

using R5T.T0131;


namespace R5T.F0055
{
	[ValuesMarker]
	public partial interface IProjectNameTokens : IValuesMarker
	{
		/// <inheritdoc cref="F0044.INameTokens.Client"/>
        public string Client => Instances.NameTokens.Client;

        /// <inheritdoc cref="F0044.INameTokens.Construction"/>
        public string Construction => Instances.NameTokens.Construction;

        /// <inheritdoc cref="F0044.INameTokens.Library"/>
        public string Library => Instances.NameTokens.Library;

        /// <inheritdoc cref="F0044.INameTokens.Server"/>
		public string Server => Instances.NameTokens.Server;
    }
}