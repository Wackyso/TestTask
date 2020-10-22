using System;
using TaskTrJunNET.Class;
using TaskTrJunNET.Interface;
using TaskTrJunNET.UI;

namespace TaskTrJunNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Firm firm = new Firm();

            UserInterface.Window(firm);
            
            
            //Worker worker = new CommonWorker("12", "12", "12", new CommonWorkerWork());
            //worker.Work();
        }
    }
}
