// ----------------------------------------------------
// COPYRIGHT (C) <TJG> ALL RIGHTS RESERVED. SEE THE LIC
// ENSE FILE FOR THE FULL LICENSE GOVERNING THIS CODE. 
// ----------------------------------------------------

using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

static class MainCode
{

    [STAThread]
    static void Main()
    {
        Application.Run(new MainWindow());
    }


    //static bool RequestStop = false;
    //[STAThread]
    //static void Main()
    //{
    //    var Thread = new Thread(Execute);
    //    //Thread.Name = "non-ui-thread";
    //    RequestStop = false;
    //    Thread.Start();
    //    // Block the MainThread until the thread is really working.
    //    while (Thread.IsAlive == false) { }

    //    for (int i = 0; i < 10; i++)
    //    {
    //        Thread.Sleep(500);
    //        Trace.WriteLine("main thread output:" + i);
    //    }
    //    RequestStop = true;
    //    Thread.Join();
    //    Trace.WriteLine("ready");

    //    //Application.Run(new MainWindow());
    //}
    //private static void Execute()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        Thread.Sleep(500);
    //        Trace.WriteLine("worker thread output:" + i);
    //    }
    //}
}
