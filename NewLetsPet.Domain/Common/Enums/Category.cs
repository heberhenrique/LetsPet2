using System;
using System.ComponentModel;

namespace NewLetsPet.Domain.Common.Enums
{
	public enum Category
	{
        [Description("Shampoo")]
        Shampoo,

        [Description("Condicionador")]
        Conditioner,

        [Description("Perfume")]
        Parfume,
    }
}

