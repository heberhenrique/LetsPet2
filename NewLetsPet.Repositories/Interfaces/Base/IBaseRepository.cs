using System;
namespace NewLetsPet.Repositories.Interfaces.Base
{
	public interface IBaseRepository<T>
	{
        public void Save(IEnumerable<T> values);
        public IEnumerable<T> Get();
    }
}

