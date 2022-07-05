using System;
using NewLetsPet.Infrastructure;
using NewLetsPet.Presentations.Screens.Login;

namespace NewLetsPet.ProgramFlows
{
	/// <summary>
    /// Represents the main application's flow.
    /// Responsible for configure all aplication paths to areas 
    /// </summary>
	public static class MainFlow
	{
		public static void BeginApp()
		{
            PetsFlow.Navigate();
        }
	}
}

