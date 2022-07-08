using System;
using NewLetsPet.Domain.Pets;

namespace NewLetsPet.Services.Interfaces
{
	public interface IGuardianService
	{
		/// <summary>
        /// Look for a guardian that matches cpf received by parameter
        /// </summary>
        /// <param name="cpf">Guardian cpf document</param>
        /// <returns>Return a Guardian instance</returns>
		public Guardian GetGuardianByCpf(string cpf);


        /// <summary>
        /// Create a guardian in database 
        /// </summary>
        /// <param name="cpf">Guardian instance</param>
        /// <returns>Return a Guardian instance</returns>
        public Guardian CreateGuardian(Guardian guardian);
    }
}

