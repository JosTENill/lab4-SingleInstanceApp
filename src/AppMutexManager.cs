using System.Threading;

namespace SingleInstanceApp
{
    public class AppMutexManager
    {
        private Mutex _mutex;
        private const string MutexName = "Global\\MyUniqueAppMutex";

        public bool IsOnlyInstance()
        {
            bool createdNew;
            _mutex = new Mutex(true, MutexName, out createdNew);
            return createdNew;
        }

        public void Release()
        {
            _mutex?.ReleaseMutex();
        }
    }
}

