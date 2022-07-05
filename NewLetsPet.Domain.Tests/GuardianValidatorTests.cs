using System;
using NewLetsPet.Domain.Pets;
using NewLetsPet.Domain.Pets.Validators;

namespace NewLetsPet.Domain.Tests
{
	public class GuardianValidatorTests
	{
        /// <summary>
        /// Result must be false because guardian has no name.
        /// </summary>
        [Fact]
        public void ValidateGuardianWithEmptyName()
        {
            // arrange
            GuardianValidator validator = new GuardianValidator();
            Guardian guardian = new Guardian();

            // act
            var result = validator.Validate(guardian);

            // assert
            Assert.False(result);
        }

        /// <summary>
        /// Result must be true because guardian has a name.
        /// </summary>
        [Fact]
        public void ValidateGuardianWithFilledName()
        {
            // arrange
            GuardianValidator validator = new GuardianValidator();
            Guardian guardian = new Guardian();
            guardian.Name = "Heber";

            // act
            var result = validator.Validate(guardian);

            // assert
            Assert.True(result);
        }

        /// <summary>
        /// Result must be false because guardian's name has numbers.
        /// </summary>
        [Fact]
        public void ValidateGuardianWithFilledNameWithNumbers()
        {
            // arrange
            GuardianValidator validator = new GuardianValidator();
            Guardian guardian = new Guardian();
            guardian.Name = "Heber 123456 Silva";

            // act
            var result = validator.Validate(guardian);

            // assert
            Assert.False(result);
        }
    }
}

