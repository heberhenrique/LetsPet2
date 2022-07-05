using System;
using NewLetsPet.Domain.Common.Validators;
using NewLetsPet.Domain.Pets;

namespace NewLetsPet.Domain.Tests
{
	public class PersonValidatorTests
	{
        /// <summary>
        /// Result must be true because document is a valid sequence.
        /// </summary>
        [Fact]
        public void ValidateAValidDocumentSequence()
        {
            // arrange
            PersonValidator validator = new PersonValidator();
            var input = "115.582.480-64";

            // act
            var result = validator.IsCpfValidSequence(input);

            // assert
            Assert.True(result);
        }

        /// <summary>
        /// Result must be false because document is an invalid sequence.
        /// </summary>
        [Fact]
        public void ValidateAnInvalidDocumentSequence()
        {
            // arrange
            PersonValidator validator = new PersonValidator();
            var input = "111.111.111-11";

            // act
            var result = validator.IsCpfValidSequence(input);

            // assert
            Assert.False(result);
        }
    }
}

