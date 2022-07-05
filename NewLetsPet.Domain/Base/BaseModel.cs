using System;
using FluentValidation;

namespace NewLetsPet.Domain.Base
{
	public interface BaseModel<T> where T : IValidator
    {
        public T Validator { get; }
        public List<string> ErrorMessages { get; }
    }
}

