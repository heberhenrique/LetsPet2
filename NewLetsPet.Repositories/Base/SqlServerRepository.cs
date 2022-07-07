using System;
using NewLetsPet.Repositories.Interfaces.Base;

namespace NewLetsPet.Repositories.Base
{
    public class SqlServerRepository<T> : IBaseRepository<T>
    {
        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<T> values)
        {
            throw new NotImplementedException();
        }
    }
}

