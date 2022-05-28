using System;
using System.Runtime.InteropServices;
using System.Threading;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
        }
        catch { }
        Console.WriteLine("Failed to fail process!");
        Console.ReadKey();

    }

    static void FailProcess()
    {
        //1)
        //Process.GetCurrentProcess().Kill();

        //2)
        //Environment.Exit(0);

        //3)
        //Environment.FailFast("asd");

        //4)
        //Thread backgroundThread = new Thread(() => Console.WriteLine("asd"));
        //backgroundThread.IsBackground = false;
        //backgroundThread.Start();
        //backgroundThread.Interrupt();

        //5)
        //var bytes = new byte[] { 42 };
        //Marshal.Copy(bytes, 0, (IntPtr)90999999999, bytes.Length); //Либо NullReference или AccessViolation

        //6)
        //Thread.CurrentThread.Abort(); //вызывает ThreadAbortException но, только на .net framework

        //7)
        //List<byte[]> list = new List<byte[]>();
        //while(true)
        //{
        //    list.Add(new byte[byte.MaxValue]); //Рано или поздно выкинет OutOfMemoryException либо просто крашнется программа
        //}

        //8)
        //FailProcess(); // StackOverflowException из-за бесконечной рекурсии
    }
}
