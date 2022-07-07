using System;
using System.ComponentModel;

namespace NewLetsPet.Domain.Common.Enums
{
	public enum ServiceTypes
	{
        [Description("Banho")]
        Bath = 1,

        [Description("Tosa")]
        Grooming = 2,
    }
}

