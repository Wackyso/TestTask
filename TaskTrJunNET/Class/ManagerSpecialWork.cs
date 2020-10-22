using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    class ManagerSpecialWork :IManagerSpecialWork
    {
        public void Work(IWorker manager, IWorker worker)
        {
            Console.WriteLine(manager.Name() + ": Дает задание работнику " + worker.Name());
        }
    }
}
