using System;

namespace SingleInstanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mutexManager = new AppMutexManager();
            if (!mutexManager.IsOnlyInstance())
            {
                Console.WriteLine("⚠️ Програма вже запущена. Завершення.");
                return;
            }

            Console.WriteLine("✅ Запущено єдиний екземпляр. Натисніть Enter для виходу.");
            Console.ReadLine();

            mutexManager.Release();
        }
    }
}


