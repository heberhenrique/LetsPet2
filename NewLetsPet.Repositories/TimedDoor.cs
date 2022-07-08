using System;
using NewLetsPet.Repositories.Interfaces;

namespace NewLetsPet.Repositories
{
	public interface ITimedDoor : IDoor, ITimerClient
    {
        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void SetTimeOut()
        {
            throw new NotImplementedException();
        }
    }
}

