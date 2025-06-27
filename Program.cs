using System;
using System.Threading;

class Program
{
    static Mutex mutex;

    static void Main()
    {
        const string mutexName = "Global\\MyUniqueAppMutex";

        bool createdNew;

        mutex = new Mutex(true, mutexName, out createdNew);

        if (!createdNew)
        {
            Console.WriteLine("Програма вже запущена.");
            return;
        }

        Console.WriteLine("Програма запущена. Натисніть Enter для виходу.");
        Console.ReadLine();

        // Вивільнити мютекс
        mutex.ReleaseMutex();
    }
}


